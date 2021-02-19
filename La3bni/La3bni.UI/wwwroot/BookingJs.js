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
                if (response.bookingsCount > 0) {
                    if (response.bookingStatus == 1 && response.bookingsCount < response.maxNumOfPlayers) { //bookingStatus ==1 means it's available
                        document.getElementById("check").value = 1;
                        document.getElementById("message").innerText = "This period has beed booked if you'd like to join this team click Book =D";
                    } else {
                        document.getElementById("check").value = 0;
                        document.getElementById("message").innerText = "This period has beed booked but you can't join sorry :(";
                    }
                } else if (response.bookingId != 0) { // != 0 in this case user has booked before
                    document.getElementById("bookBtn").value = "Cancel Booking";
                } else if (response.playgroundStatus == 1) {
                    changeBtnandMessageState(true, "We're in maintenance please be patient");
                } else {
                    document.getElementById("bookBtn").value = "Book";
                }
            }
        });
    }
}

function submit(bookingId) {
    if (document.getElementById("bookBtn").value == "Book") {
        console.log("Book");
        $.ajax({
            type: "get",
            url: "https://localhost:44379/Booking/CreateBooking",
            data:
            {
                period: document.getElementById("periods").value,
                PlaygroundId: document.getElementById("playground").value,
                selectedDate: document.getElementById("selDate").value,
            },
            success: function (msg) {
                console.log("Done");
            },
            error: function (req, status, error) {
                //console.log(msg);
            }
        });
    } else {
        console.log("Cancel Book");
    }
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

checkBooking();