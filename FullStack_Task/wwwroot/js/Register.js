$(document).ready(function () {

    var current_fs, next_fs, previous_fs;
    var counter = 1;



    // No BACK button on first screen
    if ($(".show").hasClass("first-screen")) {
        $(".prev").css({ 'display': 'none' });
    }

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

                // If Area Get All Selected Checkboxes
                if (counter == 2) {
                    var selectedAreasIds = [];
                    $.each($("input.area:checked"), function () {
                        selectedAreasIds.push($(this).val());
                    });
                    if (selectedAreasIds.length > 0) {
                        renderUIonNext(current_fs, next_fs);
                        counter++;
                    } else {
                        $('.areas-validation-message').html("At list one Buisnes Area must be selected.");
                    }
                }
                // Address State Validation
                else if (counter == 3) {
                    if ($('#State').val()) {
                        renderUIonNext(current_fs, next_fs);
                        counter++;
                    } else {
                        $('.state-validation-message').html("State is required.");
                    }
                }
                else {
                    // Register Chapta

                    renderUIonNext(current_fs, next_fs);
                    counter++;
                }
            }

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



    // Input Masks
    jQuery(function ($) {
        $(".phone").mask("(999) - 9999999", { placeholder: "  " });
        $(".fax").mask("(999) - 9999999", { placeholder: "  " });
        $(".mobile").mask("(99) - 99999999", { placeholder: "  " });
    });




    // When Country Selected Change The States
    $("#country-selection").change(function () {
        var countryName = $("#country-selection").val();
        $.ajax({
            url: `../../api/Geography/states/${countryName}`,
            type: 'GET',
            success: function (response) {
                var html = `<select class="form-control dropdown" id="State" name="State"><option value="">select</option>`;
                response.forEach(function (state) {
                    html += `<option value="${state.name}">${state.name}</option>`;
                });
                html += `</select>`;
                $('#state-drop-down').html(html);
            },
            error: function (response) {
                $('#state-drop-down').html(`
                            <select class="form-control dropdown" id="State" name="State">
                                <option value="">Select Country</option>
                            </select>
                        `);
            }
        });
    });





    // I f Area CheckBox Checked
    $("input.area").on("change", function () {
        if ($(this).is(':checked')) {
            
        } else {
            
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