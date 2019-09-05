// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var check = function () {
    if (document.getElementById('pas').value ==
        document.getElementById('repas').value) {
        document.getElementById("butt").disabled = false;
        document.getElementById('message').style.color = "blue";
        document.getElementById('message').innerHTML = 'Chính xác';
    }
    else {
        document.getElementById('message').style.color = "red";
        document.getElementById("butt").disabled = true;
        // document.getElementById("repas").className = "inpus";
        document.getElementById('message').innerHTML = 'Không chính xác';
    }
    if (document.getElementById('pas').value == "") {
        document.getElementById('message').innerHTML = '';
        document.getElementById("butt").disabled = true;
    }


}

var getIdConversation = function name() {

}
$(".list-group-item").click(function name(params) {

});

function renderPopUp(receiver, content) {
    const popup = document.getElementById("popup");
    popup.innerHTML = `<div id='test' class='modal fade' role='dialog'>
    <div class='modal-dialog'>
       <div class='modal-content'>
        <div class='modal-header'>
          <h4 class='modal-title'>${receiver}</h4>
        </div>
        <div class='modal-body'>
          <div class='video-wrapper'>
            <b>Content: </b>
            <br>
            <br>
            ${content}
          </div>
        </div>
        <div>
          <hr>
          <div class="container">
            <textarea>
          </textarea>
          </div>
         <div class="container"> <div>
         <br>
         <button class="btn-primary">Reply</button>
         <br>
         <p>‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍‍</p>
         </div>
         </div>
        </div>
      </div>
    </div>`

}

$('a.video').click(function () {
    var id = $(this).attr('attachmentid');
    var src = 'attachment.php?ref=' + id;
    $("#attachment").attr('src', src);
    $('#test').modal('show');
    return false;
});




var listName = document.getElementsByClassName('js-formatInputName')[0];
var wrapCompose = document.getElementsByClassName('wrap-compose')[0];
var NameReceiver = document.getElementsByClassName('nameReceiver');
listName.addEventListener('keydown', (e, v) => {
    var userNameHtml = document.createElement("span");
    var textnode = document.createTextNode(listName.value);
    userNameHtml.appendChild(textnode);
    userNameHtml.classList.add('nameReceiver');

    if (e.keyCode == 32 || e.keyCode == 9 || e.keyCode == 13 || e.w) {

        wrapCompose.insertBefore(userNameHtml, wrapCompose.childNodes[NameReceiver.length + 1]);
        listName.value = '';
        e.preventDefault();
    } else if (e.keyCode == 8) {
        if (NameReceiver.length == 0) {
         
        }
        else
        {
            wrapCompose.removeChild(wrapCompose.childNodes[NameReceiver.length]);
        }
    }
})
listName.addEventListener('keydown', (e) => {
    if (e.keyCode == 9) {
        e.preventDefault();
    }
})
var btnSendEmail = document.getElementById('sendEmail');
btnSendEmail.addEventListener('click', () => {
    var xhttp = new XMLHttpRequest();
    var listNameUser = '';
    for (let i = 0; i < NameReceiver.length; i++) {
        listNameUser += NameReceiver[i].innerText + ',';
    }
    document.getElementById('userName').value = listNameUser;
})


function detail(re_name, mail_title, mail_content) {
    document.getElementById("title-detail").innerHTML = mail_title;
    document.getElementById("receiver-detail").innerHTML = re_name;
    document.getElementById("content-detail").innerHTML = mail_content;
    document.getElementById("hihi").style.display = "none";
    document.getElementById("haha").style.display = "none";
    document.getElementById("maildetail").style.display = "block";
}
