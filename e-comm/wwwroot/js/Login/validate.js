$(function () {



    $.validator.addMethod("isValidEmail", function (value, element) {
        return this.optional(element) ||
            (/^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/i).test(value);
    }, "Please enter valid email address.");

    $.validator.addMethod("isValidPassword", function (value, element) {
        return this.optional(element) ||
            (/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$/i).test(value);
    }, "Minimal password length is 8 characters and must containt uppercase,numeric and special character");

    $("#login").validate(
        {
            rules: {
                Email: {
                    required: true,
                    isValidEmail: true
                },
                Password: {

                    required: true
                }
            },
            messages: {
                Email: {
                    required: "Please enter email address."
                },
                Password: {
                    required: "Please enter your password."
                }
            },
            errorPlacement: function (error, element) {
                if (element.attr("name") == "Email")
                    $(".email-error-message").append(error);
                if (element.attr("name") == "Password")
                    $(".password-error-message").append(error);
            }
        }
    );

    $("#registration").validate(
        {
            rules: {
                Username: {
                    required:true,
                    maxlength:100,
                    minlength:2
                },
                Email: {
                    required: true,
                    maxlength: 320,
                    isValidEmail: true
                },
                Password: {
                    required: true,
                    isValidPassword: true
                },
                ConfirmPassword: {
                    required: true,
                    equalTo: $("input[name='Password']")
                }
            },
            messages: {
                Username: {

                    required:"Please enter your username.",
                    maxlength:"Username is too long.",
                    minlength:"Username is too short."
                },
                Email: {
                    required: "Please enter your email address.",
                    maxlength: "Please enter a valid email adrress."
                },
                Password: {
                    required: "Please enter your password."
                },
                ConfirmPassword: {
                    required: "Confirm your password.",
                    equalTo: "Passwords are not the same!"
                }
            },
            errorPlacement: function (error, element) {
                if (element.attr("name") == "Username")
                    $(".username-error-message").append(error);
                if (element.attr("name") == "Email")
                    $(".email-error-message").append(error);
                if (element.attr("name") == "Password")
                    $(".password-error-message").append(error);
                if (element.attr("name") == "ConfirmPassword")
                    $(".check-password-error-message").append(error);
            }
        }
    );
});