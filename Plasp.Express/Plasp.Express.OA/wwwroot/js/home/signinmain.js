$(function () {
    //登录
    function login() {
        $.ajax({
            url: '/Home/Login',
            data: {
                username: $('input[name="username"]').val(),
                password: hex_md5($('input[name = "password"]').val()),
            },
            success: function (result) {
                if (result.status === 1)
                    window.location.href = "/home/index";
                else {
                    var tip = $("#loginTip");
                    tip.css({ "visibility": "visible", "color": "red" });
                    tip.text(result.remark);
                }
            }
        });
    }

    //登录-事件
    $("#btnlogin").click(function () {
        login(this);
    });
});