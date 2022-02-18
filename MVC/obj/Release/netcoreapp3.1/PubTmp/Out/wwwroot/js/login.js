//== Class Definition
var CodeSnipLogin = function () {

    var showErrorMsg = function (form, type, msg) {
        var alert = $('<div class="alert alert-' + type + ' alert-dismissible" role="alert">\
			<button type="button" class="close" data-dismiss="alert" aria-label="Close"></button>\
			<span></span>\
		</div>');

        form.find('.alert').remove();
        alert.prependTo(form);
        alert.find('span').html(msg);
    };

    var handleSignInFormSubmit = function () {
        $('#submit').click(function (e) {
            e.preventDefault();
            var btn = $(this);
            var form = $(this).closest('form');

            btn.addClass('').attr('disabled', true);

            form.ajaxSubmit({
                url: '/account/login',
                type: 'post',
                dataType: 'json',
                success: function (response, status, xhr, form) {
                    btn.removeClass('t').attr('disabled', false);

                    if (response['result']) {
                        showErrorMsg(form, 'success', response['msg']);
                        setTimeout(function () {
                            window.location = $("#ReturnUrl").val();
                        }, 500);
                    } else {
                        showErrorMsg(form, 'danger', response['msg']);
                    }
                },
                error: function showerror(xhr, status, err) {
                    showErrorMsg(form, 'danger', 'Something went wrong.<br />Please contact system administrator.<br />Error : [39647]');
                }
            });
        });
    };

    //== Public Functions
    return {
        // public functions
        init: function () {
            handleSignInFormSubmit();
        }
    };
}();

//== Class Initialization
jQuery(document).ready(function () {
    CodeSnipLogin.init();
});