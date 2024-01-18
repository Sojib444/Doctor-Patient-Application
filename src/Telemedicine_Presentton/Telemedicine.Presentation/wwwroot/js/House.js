
let houseConnection = new signalR.HubConnectionBuilder().withUrl("/hubs/houses").build();

let lbl_houseJoined = document.getElementById("lbl_houseJoined");

let btn_un_gryffindor = document.getElementById("btn_un_gryffindor");
let btn_un_slytherin = document.getElementById("btn_un_slytherin");
let btn_un_hufflepuff = document.getElementById("btn_un_hufflepuff");
let btn_un_ravenclaw = document.getElementById("btn_un_ravenclaw");
let btn_gryffindor = document.getElementById("btn_gryffindor");
let btn_slytherin = document.getElementById("btn_slytherin");
let btn_hufflepuff = document.getElementById("btn_hufflepuff");
let btn_ravenclaw = document.getElementById("btn_ravenclaw");

//Adding 
btn_gryffindor.addEventListener("click", function (event) {
    houseConnection.send("JoinHouse", "Gryffindor");
    event.preventDefault();
});
btn_hufflepuff.addEventListener("click", function (event) {
    houseConnection.send("JoinHouse", "Hufflepuff");
    event.preventDefault();
});
btn_ravenclaw.addEventListener("click", function (event) {
    houseConnection.send("JoinHouse", "Ravenclaw");
    event.preventDefault();
});
btn_slytherin.addEventListener("click", function (event) {
    houseConnection.send("JoinHouse", "Slytherin");
    event.preventDefault();
});


//removinf
btn_un_gryffindor.addEventListener("click", function (event) {
    houseConnection.send("LeaveHouse", "Gryffindor");
    event.preventDefault();
});
btn_un_hufflepuff.addEventListener("click", function (event) {
    houseConnection.send("LeaveHouse", "Hufflepuff");
    event.preventDefault();
});
btn_un_ravenclaw.addEventListener("click", function (event) {
    houseConnection.send("LeaveHouse", "Ravenclaw");
    event.preventDefault();
});
btn_un_slytherin.addEventListener("click", function (event) {
    houseConnection.send("LeaveHouse", "Slytherin");
    event.preventDefault();
});


houseConnection.on("subscriptionStatus", (houseList, houseName, isJoind) => {
    lbl_houseJoined.innerText = houseList;

    if (isJoind) {
        switch (houseName) {
            case 'slytherin':
                btn_slytherin.style.display = 'none';
                btn_un_slytherin.style.display = "";
                break;
            case 'ravenclaw':
                btn_ravenclaw.style.display = 'none';
                btn_un_ravenclaw.style.display = "";
                break;
            case 'hufflepuff':
                btn_hufflepuff.style.display = 'none';
                btn_un_hufflepuff.style.display = "";
                break;
            default:
                btn_gryffindor.style.display = 'none';
                btn_un_gryffindor.style.display = "";
                break;
        }
        toastr.success(`You have Subscribed Successfully. ${houseName}`);
    }
    else {
        switch (houseName) {
            case 'slytherin':
                btn_slytherin.style.display = '';
                btn_un_slytherin.style.display = 'none';
                break;
            case 'ravenclaw':
                btn_ravenclaw.style.display = '';
                btn_un_ravenclaw.style.display = 'none';
                break;
            case 'hufflepuff':
                btn_hufflepuff.style.display = '';
                btn_un_hufflepuff.style.display = 'none';
                break;
            default:
                btn_gryffindor.style.display = '';
                btn_un_gryffindor.style.display = 'none';
                break;
        }
        toastr.success(`You have Unsubscribed Successfully. ${houseName}`);
    }
})

houseconnection.on("subcription", (housename) => {
    toastr.success(`${housename} has a new member.`)
})

houseConnection.on("UnSubcription", (houseName) => {
    toastr.success(`${houseName} has lost a member.`)
})

function Success() {
    console.log("Connection SuccessFull");
}

function Fail() {
    console.log("Connection SuccessFull");
}

houseConnection.start().then(Success, Fail);