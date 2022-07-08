function doFirst() {
    // 先跟 HTML 畫面產生關聯，再建事件聆聽功能
    let canvas = document.getElementById('canvas')
    let context = canvas.getContext('2d')

    context.fillStyle = 'red';
    context.strokeStyle = 'blue';

    context.fillRect(100, 100, 300, 200);
    // context.strokeRect(100, 100, 300, 200);
    context.clearRect(150, 150, 50, 50);

    context.rect(700, 500, 300, 300);
    context.stroke();
    // context.fill();

    // 橡皮擦
    // context.clearRect(0, 0, canvas.width, canvas.height);

}
window.addEventListener('load', doFirst)
// window.onload = doFirst
// window.onload = function(){}