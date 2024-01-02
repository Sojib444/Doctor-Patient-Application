
//Establish conncetion
let userCount = new signalR.HubConnectionBuilder().withUrl("hubs/countuser").build();

//Connect the methods that hub invokes 
userCount.on("UpateCount", (value) => {
    let countspan = document.getElementById("totalCount");
    countspan.innerText = value.toString();
});


//Connect the methods that hub invokes 
userCount.on("TotalCount", (value) => {
    let countspan = document.getElementById("totalTabCount");
    countspan.innerText = value.toString();
});


//Invoke Hub Method to send Notification to hub
function InvokeHubMethod() {
    userCount.send("NewWindowLoading",);
}

function Fulfill() {
    console.log("Connection is Seccessful")
    InvokeHubMethod();
}

function Rejected() {
    console.log("Connection is not Seccessful")
}

//start Connection
userCount.start().then(Fulfill, Rejected);
