$(document).ready(function () {

    var current_fs, next_fs, previous_fs;
    var counter = 1;


    // No BACK button on first screen
    if ($(".show").hasClass("first-screen")) {
        $(".prev").css({ 'display': 'none' });
    }


    // Areas Validation Message Display None
    $('.areas-validation-message').css("display", "none");

    // CaptCha Validation Error Display None
    $(".captcha-validation-message").css("display", "none");

    // Accept Terms Validasion Message Display None
    $(".accept-terms-validation-essage").css("display", "none");

    // State Validation Mesage Display None
    $(".state-validation-message").css("display", "none");


    // Update The Tab Title With The Title Of The First Tab
    current_fs = $(".steps-container").find(`[data-counter='${1}']`);
    var tabTitle = $(current_fs).children('input[name="title"]').val();
    $('.display-screen').html(tabTitle)


    $("*").validate();


    // Next button
    $(".next-button").click(function () {
        if (counter == 0 || counter <= 4) {
            // Get Current And Next Tab
            current_fs = $(".steps-container").find(`[data-counter='${counter}']`);
            next_fs = $(".steps-container").find(`[data-counter='${counter}']`).next();

            // Selected Tab Form Submited
            var form = $(current_fs).find(`form`);
            $("*").resetValidation();
            if (form.valid()) {
                // Contact Info
                if (counter == 1) {
                    renderUIonNext(current_fs, next_fs);
                    counter++;
                }
                // Areas
                else if (counter == 2) {
                    checkSelectedAreas(() => {
                        renderUIonNext(current_fs, next_fs);
                        counter++;
                    });
                }
                // Address
                else if (counter == 3) {
                    if ($('#State').val()) {
                        $('.state-validation-message').css("display", "none");
                        renderUIonNext(current_fs, next_fs);
                        counter++;
                    } else {
                        $('.state-validation-message').css("display", "block");
                    }
                }
                // Password
                else if (counter == 4) {
                    customCaptChaValidation();
                }
            }
        }
        // Completed
        else {
            createUser();
        }
    });

    // Previous button
    $(".prev").click(function () {
        if (counter >= 1) {
            counter--;

            // Get Current And Previus Tab
            current_fs = $(".show");
            previous_fs = $(".show").prev();

            renderUionBack(current_fs, previous_fs);
        }

    });


    function renderUIonNext(current_fs, next_fs) {
        // Update Tab Sub Title Based On Current Tab
        var tabTitle = $(next_fs).children('input[name="title"]').val();
        $('.display-screen').html(tabTitle)


        // Display The curent Tab Only
        $(".prev").css({ 'display': 'block' });
        $(current_fs).removeClass("show");
        $(next_fs).addClass("show");
        if ($(".show").hasClass("last-screen")) {
            $(".next-button").css({ 'display': 'none' });
        }
        current_fs.animate({}, {
            step: function () {
                current_fs.css({
                    'display': 'none',
                    'position': 'relative'
                });
                next_fs.css({
                    'display': 'block'
                });
            }
        });

        // Activate The Right List Node Based On Current Tab
        var current_proccess_tab = $("#progressbar li").eq($(".card2").index(next_fs));
        $(current_proccess_tab).prev().removeClass("active");
        if (counter == 1)
            $(current_proccess_tab).prev().addClass("onec");
        if (counter == 2)
            $(current_proccess_tab).prev().addClass("towc");
        if (counter == 3)
            $(current_proccess_tab).prev().addClass("threec");
        if (counter == 4)
            $(current_proccess_tab).prev().addClass("fourc");
        $(current_proccess_tab).removeClass("one");
        $(current_proccess_tab).removeClass("tow");
        $(current_proccess_tab).removeClass("three");
        $(current_proccess_tab).removeClass("four");
        $(current_proccess_tab).removeClass("five");
        $(current_proccess_tab).addClass("active");
    }

    function renderUionBack(current_fs, previous_fs) {
        // Update Tab Sub Title Based On Current Tab
        var tabTitle = $(previous_fs).children('input[name="title"]').val();
        $('.display-screen').html(tabTitle);

        // Display The curent Tab Only
        $(current_fs).removeClass("show");
        $(previous_fs).addClass("show");
        $(".prev").css({ 'display': 'block' });
        if ($(".show").hasClass("first-screen")) {
            $(".prev").css({ 'display': 'none' });
        }
        if (!$(".show").hasClass("last-screen")) {
            $(".next-button").css({ 'display': 'block' });
        }
        current_fs.animate({}, {
            step: function () {

                current_fs.css({
                    'display': 'none',
                    'position': 'relative'
                });

                previous_fs.css({
                    'display': 'block'
                });
            }
        });

        // Activate The Right List Node Based On Current Tab
        var current_proccess_tab = $("#progressbar li").eq($(".card2").index(current_fs));
        $(current_proccess_tab).removeClass("active");
        var previus_proccess_tab = $("#progressbar li").eq($(".card2").index(previous_fs));
        $(previus_proccess_tab).removeClass("one");
        $(previus_proccess_tab).removeClass("tow");
        $(previus_proccess_tab).removeClass("three");
        $(previus_proccess_tab).removeClass("four");
        $(previus_proccess_tab).removeClass("five");
        $(previus_proccess_tab).removeClass("onec");
        $(previus_proccess_tab).removeClass("towc");
        $(previus_proccess_tab).removeClass("threec");
        $(previus_proccess_tab).removeClass("fourc");
        $(previus_proccess_tab).removeClass("fivec");
        $(previus_proccess_tab).addClass("active");
        if (counter == 0)
            $(current_proccess_tab).addClass("tow");
        if (counter == 1)
            $(current_proccess_tab).addClass("three");
        if (counter == 2)
            $(current_proccess_tab).addClass("four");
        if (counter == 3)
            $(current_proccess_tab).addClass("five");
    }

    function checkSelectedAreas(func) {
        var selectedAreasIds = [];
        $.each($("input.area:checked"), function () {
            selectedAreasIds.push($(this).val());
        });
        if (selectedAreasIds.length > 0) {
            $('.areas-validation-message').css("display", "none");
            func();
        } else {
            $('.areas-validation-message').css("display", "block");
        }
    }

    // CaptCha
    function refreshCaptCha() {
        $("#refresh-captcha").click(function () {
            resetCaptchaImage();
        });
        function resetCaptchaImage() {
            d = new Date();
            $("#img-captcha").attr("src", "../../api/Captcha");
        }
    }
    function customCaptChaValidation() {
        var captcha = $("#captcha-input").val();
        CaptchaValidation(captcha, function () {
            $(".captcha-validation-message").css("display", "none");
            if ($("*[name='AcceptTerms']").is(':checked')) {
                renderUIonNext(current_fs, next_fs);
                counter++;
                createUser();
            } else {
                $(".accept-terms-validation-essage").css("display", "block");
            }
        }, function () {
            $(".captcha-validation-message").css("display", "block");
        });
    }
    refreshCaptCha();

    function collectUsersData() {
        var SalutationId = $("*[name='SalutationId']").val();
        var FirstName = $("*[name='FirstName']").val();
        var MiddleName = $("*[name='MiddleName']").val();
        var LastName = $("*[name='LastName']").val();
        var Company = $("*[name='Company']").val();
        var Title = $("*[name='Title']").val();
        var Email = $("*[name='Email']").val();
        var Phone = $("*[name='Phone']").val();
        var Fax = $("*[name='Fax']").val();
        var Mobile = $("*[name='Mobile']").val();
        var BusinessAreas = [];
        $.each($("input.area:checked"), function () {
            BusinessAreas.push($(this).val());
        });
        var Comment = $("*[name='Comment']").val();
        var Country = $("*[name='Country']").val();
        var OfficeName = $("*[name='OfficeName']").val();
        var Street = $("*[name='Street']").val();
        var PostalCode = $("*[name='PostalCode']").val();
        var City = $("*[name='City']").val();
        var State = $("*[name='State']").val();
        var Password = $("*[name='Password']").val();
        var AcceptTerms = $("*[name='AcceptTerms']").is(':checked');
        return {
            SalutationId: SalutationId,
            FirstName: FirstName,
            MiddleName: MiddleName,
            LastName: LastName,
            Company: Company,
            Title: Title,
            Email: Email,
            Phone: Phone,
            Fax: Fax,
            Mobile: Mobile,
            BAreas: BusinessAreas,
            Message: Comment,
            Country: Country,
            OfficeName: OfficeName,
            Street: Street,
            PostalCode: PostalCode,
            City: City,
            State: State,
            Password: Password,
            AcceptTerms: AcceptTerms
        }
    }

    function createUser() {
        var user = collectUsersData();
        registerUser(user, response => {
            console.log(response);
        });
    }


    // Input Masks
    jQuery(function ($) {
        $(".phone").mask("(999) - 9999999", { placeholder: "  " });
        $(".fax").mask("(999) - 9999999", { placeholder: "  " });
        $(".mobile").mask("(99) - 99999999", { placeholder: "  " });
    });


    // When Country Selected Change The States
    $("#country-selection").change(function () {
        var countryName = $("#country-selection").val();
        onCoyntrySelected(countryName, function (response) {
            var html = `<select class="form-control dropdown" id="State" name="State"><option value="">select</option>`;
            response.forEach(function (state) {
                html += `<option value="${state.state_name}">${state.state_name}</option>`;
            });
            html += `</select>`;
            $('#state-drop-down').html(html);
        }, function (response) {
            $('#state-drop-down').html(`
                <select class="form-control dropdown" id="State" name="State">
                    <option value="">Select Country</option>
                </select>
            `);
        });
    });


    // I f Area CheckBox Checked
    $("input.area").on("change", function () {
        checkSelectedAreas(() => { });
    });


    // On CaptCha Input Change
    $('#captcha-input').change(function () {
        var captcha = $("#captcha-input").val();
        CaptchaValidation(captcha, function () {
            $("#captcha-validation-message").html("");
        }, function () {
            $(".captcha-validation-message").css("display", "block");
        });
    });


    // Kendo PopOver
    $(".target").kendoPopover({
        /*showOn: "click",*/
        header: function (e) {
            return `<h5 class="kendo-header">Error</h5>`;
        },
        body: function (e) {
            return `<span class="text-danger">${$(e.target).children().text()}</span>`;
        }
    });

});









// Serial Object from Form
(function ($) {
    $.fn.serializeObject = function () {
        var o = {};
        var a = this.serializeArray();
        $.each(a, function () {
            if (o[this.name]) {
                if (!o[this.name].push) {
                    o[this.name] = [o[this.name]];
                }
                o[this.name].push(this.value || '');
            } else {
                o[this.name] = this.value || '';
            }
        });
        return o;
    };
})(jQuery);




//clear validation on reset button clicked
(function ($) {
    //re-set all client validation given a jQuery selected form or child
    $.fn.resetValidation = function () {
        var $form = this.closest('form');

        //reset jQuery Validate's internals
        $form.validate().resetForm();

        //reset unobtrusive validation summary, if it exists
        $form.find("[data-valmsg-summary=true]")
            .removeClass("validation-summary-errors")
            .addClass("validation-summary-valid")
            .find("ul").empty();

        //reset unobtrusive field level, if it exists
        $form.find("[data-valmsg-replace]")
            .removeClass("field-validation-error")
            .addClass("field-validation-valid")
            .empty();

        return $form;
    };
})(jQuery);