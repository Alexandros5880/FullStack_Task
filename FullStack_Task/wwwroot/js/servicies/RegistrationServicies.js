

function CaptchaValidation(captcha, onTrueCallBack, onFalseCallBack) {
    $.ajax({
        async: true,
        url: `/api/Captcha/Validate?userCaptcha=${captcha}`,
        type: 'GET',
        success: function (response) {
            if (response === true) {
                onTrueCallBack();
            } else {
                onFalseCallBack();
            }
        },
        error: function (response) {
            onFalseCallBack();
        }
    });
}

function onCoyntrySelected(countryName, successCallBack, errorCallBack) {
    $.ajax({
        url: `../../api/Geography/states/${countryName}`,
        type: 'GET',
        success: function (response) {
            successCallBack(response);
        },
        error: function (response) {
            errorCallBack(response);
        }
    });
}