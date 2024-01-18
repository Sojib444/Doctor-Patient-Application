let chatConnection = new signalR.HubConnectionBuilder().withUrl("/hubs/chat").build();

let btn = document.getElementById("sendMessage");
btn.disabled = true;

chatConnection.on("ReceiveMassage", (message) => {
    var messageList = document.getElementById("messagesList");

    let li = document.createElement("li");
    li.textContent = message;
    messageList.appendChild(li);

    toastr.success(`Massage Successfully send`);
})

btn.addEventListener("click", function (event) {
    let message = document.getElementById("chatMessage").value;
    let senderEmail = document.getElementById("senderEmail").value;
    let receiverEmail = document.getElementById("receiverEmail").value;

    chatConnection.send("SendMesssss", message, senderEmail, receiverEmail);

    event.preventDefault();
})

chatConnection.start().then(function () {
    document.getElementById("sendMessage").disabled = false;
})