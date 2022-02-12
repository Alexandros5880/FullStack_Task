// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




$(function () {
    // Run this function for all validation error messages
    $('.field-validation-error').each(function () {

        // Get the error text to be displayed
        var errorText = $(this).text();

        // Remove the text from the error message span
        // element and add the classes to display the icon
        $(this).empty();
        $(this).addClass("ui-state-error-icon").addClass("ui-icon-alert");

        // Wire up the tooltip to display the error message
        $(this).qtip({
            overwrite: true,
            content: errorText,
            style: {
                classes: 'ui-tooltip-red'
            }
        });
    });
});