$(document).ready(function () {

    var current_fs, next_fs, previous_fs;
    var counter = 0;



    // No BACK button on first screen
    if ($(".show").hasClass("first-screen")) {
        $(".prev").css({ 'display': 'none' });
    }







    // Next button
    $(".next-button").click(function () {
        if (counter < 4) {
            counter++;

            //$(".display-screen")

            // Validation system
            // If Validate Go To Next


            


            current_fs = $(".steps-container").find(`[data-counter='${counter}']`);
            next_fs = $(".steps-container").find(`[data-counter='${counter}']`).next();

            $(".prev").css({ 'display': 'block' });

            $(current_fs).removeClass("show");
            $(next_fs).addClass("show");

            if ($(".show").hasClass("last-screen")) {
                $(".next-button").css({ 'display': 'none' });
            }





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



            

        }
    });



    // Previous button
    $(".prev").click(function () {
        if (counter >= 1) {
            counter--;

            current_fs = $(".show");
            previous_fs = $(".show").prev();

            $(current_fs).removeClass("show");
            $(previous_fs).addClass("show");

            $(".prev").css({ 'display': 'block' });

            if ($(".show").hasClass("first-screen")) {
                $(".prev").css({ 'display': 'none' });
            }
            if (!$(".show").hasClass("last-screen")) {
                $(".next-button").css({ 'display': 'block' });
            }





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



            

            //console.log(counter);
            //if (counter == 0)
            //    $(current_proccess_tab).addClass("one");
            if (counter == 0)
                $(current_proccess_tab).addClass("tow");
            if (counter == 1)
                $(current_proccess_tab).addClass("three");
            if (counter == 2)
                $(current_proccess_tab).addClass("four");
            if (counter == 3)
                $(current_proccess_tab).addClass("five");
            
            



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
        }
    });



});