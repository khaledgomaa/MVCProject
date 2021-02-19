function checkBooking(PlaygroundId, selectedValue) {
    $.ajax({
        url: 'https://localhost:44379/Booking/GetBookings',
        type: "get", //send it through get method
        data: {
            playGroundId: PlaygroundId,
            date: document.getElementById("selDate").value,
            timeId: selectedValue.value
        },
        success: function (response) {
            if (response.length > 0) {
                if (response[0].bookingStatus == 1 && response.length < response[0].maxNumOfPlayers) {
                    document.getElementById("check").value = 1;
                    document.getElementById("message").innerText = "This period has beed booked if you'd like to join this team click Book =D";
                } else {
                    document.getElementById("check").value = 0;
                    document.getElementById("message").innerText = "This period has beed booked but you can't join sorry :(";
                }
            }
        },
        error: function (xhr) {
            //Do Something to handle error
        }
    });
}