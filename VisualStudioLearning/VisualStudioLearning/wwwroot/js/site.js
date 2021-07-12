// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

//animation

var id = null;
function myMove() {
    var element = document.getElementById("Animation");
    var position = 50;
    clearInterval(id);
    id = setInterval(frame, 5);
    function frame() {
        if (position == 250) {
            clearInterval(id);
        } else {
            position++;
            element.style.top = position + 'px';
            element.style.left = position + 'px';
        }
    }
}