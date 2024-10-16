let registeruser1 = document.getElementById("registeruser");
let registerbrand2 = document.getElementById("registerbrand");
let btnuserid1 = document.getElementById("btnuserid");
let btbtnbrandid2 = document.getElementById("btnbrandid");


function btnuser() {
    registeruser1.style.transform = "translatex(0)";
    registerbrand2.style.transform = "translatex(150%)";

    registeruser1.style.transitionDelay = "0.5s";
    registerbrand2.style.transitionDelay = "0";


    btnuserid1.style.background = "#F2F2F2";
    btbtnbrandid2.style.background = "#003049";


    btnuserid1.style.color = "#1D3557";
    btbtnbrandid2.style.color = "#FFFFFF";
    console.log(btnuserid1);

}

function btnbrand() {
    registeruser1.style.transform = "translatex(150%)";
    registerbrand2.style.transform = "translatex(0)";

    registerbrand2.style.transitionDelay = "0.5s";
    registeruser1.style.transitionDelay = "0";

    btbtnbrandid2.style.background = "#F2F2F2";
    btnuserid1.style.background = "#003049";

    btbtnbrandid2.style.color = "#1D3557";
    btnuserid1.style.color = "#FFFFFF";
    console.log(btbtnbrandid2)

}