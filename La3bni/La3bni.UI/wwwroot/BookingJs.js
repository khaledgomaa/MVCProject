var bookingId = 0;
function checkBooking() {
    if (checkDateIsValid()) {
        $.ajax({
            url: 'https://localhost:44379/Booking/GetBookings',
            type: "get", //send it through get method
            data: {
                playGroundId: document.getElementById("playground").value,
                date: document.getElementById("selDate").value,
                timeId: document.getElementById("periods").value
            },
            success: function (response) {
                console.log(response);
                if (response.bookingExist == true) {
                    document.getElementById("bookBtn").value = "Join Team";
                    removeMaxNumOfPlayers();
                    if (response.numOfPlayers < response.maxNumOfPlayers) { //bookingStatus ==1 means it's available
                        changeBtnandMessageState(false, "This period has beed booked if you'd like to join this team click Join team =D");

                        bookingId = response.bookingId;
                        console.log(bookingId);
                    } else {
                        changeBtnandMessageState(true, "This period has beed booked but you can't join sorry :(");
                    }
                } else if (response.bookingId != 0) { // != 0 in this case user has booked before
                    bookingId = response.bookingId;
                    if (response.bookingOwner == false) {
                        removeMaxNumOfPlayers()
                        document.getElementById("bookBtn").value = "Leave Team";
                    } else {
                        removeMaxNumOfPlayers();
                        document.getElementById("bookBtn").value = "Cancel Booking";
                    }
                } else if (response.playgroundStatus == 1) {
                    changeBtnandMessageState(true, "We're in maintenance please be patient");
                } else {
                    document.getElementById("bookBtn").value = "Book";
                    addMaxNumOfplayersandChecking();
                }
            }
        });
    } else {
        document.getElementById("bookBtn").value = "Book";
    }
}

function addMaxNumOfplayersandChecking() {
    if (document.getElementsByName("maxNum").length == 0) {
        $("<label name='numOf' style='margin-top:10%' class='control - label'>num of players can join</label><input type='number' value='0' name='maxNum' min='0'  />").insertAfter("#message");

        document.getElementsByName("maxNum")[0].addEventListener("keypress", function (e) {
            e.preventDefault();
        });
    }
}

function removeMaxNumOfPlayers() {
    var inputNumber = document.getElementsByName("maxNum");
    var label = document.getElementsByName("numOf");
    if (inputNumber.length != 0 && label.length != 0) {
        inputNumber[0].remove();
        label[0].remove();
    }
}

function submit() {
    //createCookieForDateAndPeriod();
    if (document.getElementById("bookBtn").value == "Book") {
        CreateBooking();
    } else if (document.getElementById("bookBtn").value == "Join Team") {
        joinTeam();
    } else if (document.getElementById("bookBtn").value == "Cancel Booking") {
        CancelBooking();
    } else if (document.getElementById("bookBtn").value == "Leave Team") {
        LeaveTeam();
    }
    //resetDateAndPeriod();
}

function CreateBooking() {
    $.ajax({
        type: "get",
        url: "https://localhost:44379/Booking/CreateBooking",
        data:
        {
            period: document.getElementById("periods").value,
            PlaygroundId: document.getElementById("playground").value,
            selectedDate: document.getElementById("selDate").value,
            numOfPlayers: document.getElementsByName("maxNum")[0].value
        },
        success: function (response) {
            window.location.href = response.redirectToUrl;
        },
        error: function (req, status, error) {
            //console.log(msg);
        }
    });
}

function joinTeam() {
    $.ajax({
        type: "get",
        url: "https://localhost:44379/Booking/JoinTeam",
        data:
        {
            bookingId: bookingId
        },
        success: function (response) {
            console.log(response);
            window.location.href = response.redirectToUrl;
        },
        error: function (req, status, error) {
            //console.log(msg);
        }
    });
}

function CancelBooking() {
    $.ajax({
        type: "get",
        url: "https://localhost:44379/Booking/CancelBooking",
        data:
        {
            bookingId: bookingId
        },
        success: function (response) {
            console.log(response);
            window.location.href = response.redirectToUrl;
        },
        error: function (req, status, error) {
            //console.log(msg);
        }
    });
}

function LeaveTeam() {
    $.ajax({
        type: "get",
        url: "https://localhost:44379/Booking/LeaveTeam",
        data:
        {
            bookingId: bookingId
        },
        success: function (response) {
            console.log(response);
            window.location.href = response.redirectToUrl;
        },
        error: function (req, status, error) {
            //console.log(msg);
        }
    });
}

function checkDateIsValid() {
    var today = new Date();
    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
    var yyyy = today.getFullYear();

    today = mm + '/' + dd + '/' + yyyy;
    if (new Date(document.getElementById("selDate").value) < new Date(today)) {
        changeBtnandMessageState(true, "Please select a valid date");
        return false;
    }
    changeBtnandMessageState(false, "");
    return true;
}

function changeBtnandMessageState(btnState, message) {
    document.getElementById("bookBtn").disabled = btnState;
    document.getElementById("message").innerText = message;
}

function CustomConfirm() {
    this.render = function (dialog) {
        dialog = "Click yes to confirm";
        var winW = window.innerWidth;
        var winH = window.innerHeight;
        var dialogoverlay = document.getElementById('dialogoverlay');
        var dialogbox = document.getElementById('dialogbox');
        dialogoverlay.style.display = "block";
        dialogoverlay.style.height = winH + "px";
        dialogbox.style.left = (winW / 2) - (550 * .5) + "px";
        dialogbox.style.top = "100px";
        dialogbox.style.display = "block";

        document.getElementById('dialogboxhead').innerHTML = "Confirm that action";
        document.getElementById('dialogboxbody').innerHTML = dialog;
        document.getElementById('dialogboxfoot').innerHTML = '<button onclick="Confirm.yes()">Yes</button> <button onclick="Confirm.no()">No</button>';
    }
    this.no = function () {
        document.getElementById('dialogbox').style.display = "none";
        document.getElementById('dialogoverlay').style.display = "none";
        //console.log("No");
        //noCallBack();
    }
    this.yes = function () {
        document.getElementById('dialogbox').style.display = "none";
        document.getElementById('dialogoverlay').style.display = "none";
        submit();
        //yesCallBack();
    }
}
var Confirm = new CustomConfirm();

//var literCookies = [];
//function getCookie(cookieName) {
//    var cookies = document.cookie.split(";");
//    for (var i = 0; i < cookies.length; i++) {
//        literCookies[cookies[i].split("=")[0].trim()] = cookies[i].split("=")[1];
//    }
//    console.log(literCookies);
//    return literCookies[cookieName];
//}

//function resetDateAndPeriod() {
//    var x = "2021/21/02";
//    console.log(Date.parse(x.replaceAll("/", " ")));
//    document.getElementById("selDate").value = Date.parse(x.replaceAll("/", " "));
//    //console.log(getCookie("curPeriod"));
//    //console.log(getCookie("curDate"));
//    document.getElementById("periods").value = 7;
//}

//function createCookieForDateAndPeriod() {
//    document.cookie = "curDate" + "=" + document.getElementById("selDate").value;
//    document.cookie = "curPeriod" + "=" + document.getElementById("periods").value;
//}

checkBooking();