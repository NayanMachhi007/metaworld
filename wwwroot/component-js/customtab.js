var content1 = document.getElementById("tab-content-1");
var content2 = document.getElementById("tab-content-2");
var content3 = document.getElementById("tab-content-3");
var content4 = document.getElementById("tab-content-4");
var content5 = document.getElementById("tab-content-5");

var btn1 = document.getElementById("btn1");
var btn2 = document.getElementById("btn2");
var btn3 = document.getElementById("btn3");
var btn4 = document.getElementById("btn4");
var btn5 = document.getElementById("btn5");


function taboneclick() {
    console.log(content1);
    content1.style.transform = "translatex(0)";
    content2.style.transform = "translatex(100%)";
    content3.style.transform = "translatex(100%)";
    content4.style.transform = "translatex(100%)";
    content5.style.transform = "translatex(100%)";

    btn1.style.background = "#003049";
    btn2.style.background = "#F4F6FD";
    btn3.style.background = "#F4F6FD";
    btn4.style.background = "#F4F6FD";
    btn5.style.background = "#F4F6FD";

    btn1.style.color = "#FFFFFF";
    btn2.style.color = "#D3D4DA";
    btn3.style.color = "#D3D4DA";
    btn4.style.color = "#D3D4DA";
    btn5.style.color = "#D3D4DA";

    content1.style.transitionDelay = "0.5s";
    content2.style.transitionDelay = "0s";
    content3.style.transitionDelay = "0s";
    content4.style.transitionDelay = "0s";
    content5.style.transitionDelay = "0s";


}

function tabtwoclick() {
    console.log(content1);
    content1.style.transform = "translatex(100%)";
    content2.style.transform = "translatex(0)";
    content3.style.transform = "translatex(100%)";
    content4.style.transform = "translatex(100%)";
    content5.style.transform = "translatex(100%)";

    btn2.style.background = "#003049";
    btn3.style.background = "#F4F6FD";
    btn1.style.background = "#F4F6FD";
    btn4.style.background = "#F4F6FD";
    btn5.style.background = "#F4F6FD";

    btn2.style.color = "#FFFFFF";
    btn1.style.color = "#D3D4DA";
    btn3.style.color = "#D3D4DA";
    btn4.style.color = "#D3D4DA";
    btn5.style.color = "#D3D4DA";

    content1.style.transitionDelay = "0s";
    content2.style.transitionDelay = "0.5s";
    content3.style.transitionDelay = "0s";
    content4.style.transitionDelay = "0s";
    content5.style.transitionDelay = "0s";
}

function tabthreeclick() {
    console.log(content1);
    content1.style.transform = "translatex(100%)";
    content2.style.transform = "translatex(100%)";
    content3.style.transform = "translatex(0)";
    content4.style.transform = "translatex(100%)";
    content5.style.transform = "translatex(100%)";

    btn3.style.background = "#003049";
    btn2.style.background = "#F4F6FD";
    btn1.style.background = "#F4F6FD";
    btn4.style.background = "#F4F6FD";
    btn5.style.background = "#F4F6FD";

    btn3.style.color = "#FFFFFF";
    btn2.style.color = "#D3D4DA";
    btn1.style.color = "#D3D4DA";
    btn4.style.color = "#D3D4DA";
    btn5.style.color = "#D3D4DA";

    content1.style.transitionDelay = "0s";
    content2.style.transitionDelay = "0s";
    content3.style.transitionDelay = "0.5s";
    content4.style.transitionDelay = "0s";
    content5.style.transitionDelay = "0s";
}

function tabfourclick() {
    console.log(content1);
    content1.style.transform = "translatex(100%)";
    content2.style.transform = "translatex(100%)";
    content3.style.transform = "translatex(100%)";
    content4.style.transform = "translatex(0)";
    content5.style.transform = "translatex(100%)";

    btn4.style.background = "#003049";
    btn3.style.background = "#F4F6FD";
    btn2.style.background = "#F4F6FD";
    btn1.style.background = "#F4F6FD";
    btn5.style.background = "#F4F6FD";


    btn4.style.color = "#FFFFFF";
    btn3.style.color = "#D3D4DA";
    btn2.style.color = "#D3D4DA";
    btn1.style.color = "#D3D4DA";
    btn5.style.color = "#D3D4DA";

    content1.style.transitionDelay = "0s";
    content2.style.transitionDelay = "0s";
    content3.style.transitionDelay = "0s";
    content4.style.transitionDelay = "0.5s";
    content5.style.transitionDelay = "0s";
}

function tabfiveclick() {
    console.log(content1);
    content1.style.transform = "translatex(100%)";
    content2.style.transform = "translatex(100%)";
    content3.style.transform = "translatex(100%)";
    content4.style.transform = "translatex(100%)";
    content5.style.transform = "translatex(0)";

    btn5.style.background = "#003049";
    btn3.style.background = "#F4F6FD";
    btn2.style.background = "#F4F6FD";
    btn1.style.background = "#F4F6FD";
    btn4.style.background = "#F4F6FD";

    btn5.style.color = "#FFFFFF";
    btn3.style.color = "#D3D4DA";
    btn2.style.color = "#D3D4DA";
    btn1.style.color = "#D3D4DA";
    btn4.style.color = "#D3D4DA";

    content1.style.transitionDelay = "0s";
    content2.style.transitionDelay = "0s";
    content3.style.transitionDelay = "0s";
    content4.style.transitionDelay = "0s";
    content5.style.transitionDelay = "0.5s";
}