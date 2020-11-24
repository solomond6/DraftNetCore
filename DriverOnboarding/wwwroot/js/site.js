// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    //validation
    //$("input, select").tooltipster({
    //    trigger: "custom",
    //    onlyOne: false,
    //    position: "bottom",
    //    //theme: "tooltipster-default",
    //    //positionTracker: true
    //});

    ////$('form input select').tooltipster({  // <-  USE THE PROPER SELECTOR FOR YOUR INPUTs
    ////    trigger: 'custom', // default is 'hover' which is no good here
    ////    onlyOne: false,    // allow multiple tips to be open at a time
    ////    position: 'right'  // display the tips to the right of the element
    ////});

    //$("#form").validate({
    //    errorPlacement: function (error, element) {
    //        var lastError = $(element).data("lastError"),
    //            newError = $(error).text();

    //        $(element).data("lastError", newError);

    //        if (newError !== "" && newError !== lastError) {
    //            $(element).tooltipster("content", newError);
    //            $(element).tooltipster("show");
    //        }
    //    },
    //    success: function (label, element) {
    //        $(element).tooltipster("hide");
    //    }
    //});

    /* This code handles all of the navigation stuff.
     ** Probably leave it. Credit to https://bootsnipp.com/snippets/featured/form-wizard-and-validation
     */
    var navListItems = $("div.setup-panel div a"),
        allWells = $(".setup-content"),
        allNextBtn = $(".nextBtn"),
        allPrevBtn = $(".prevBtn");

    allWells.hide();

    navListItems.click(function (e) {
        e.preventDefault();
        var $target = $($(this).attr("href")),
            $item = $(this);

        if (!$item.hasClass("disabled")) {
            navListItems.removeClass("btn-primary").addClass("btn-default");
            $item.addClass("btn-primary");
            //$("input, select").tooltipster("hide");
            allWells.hide();
            $target.show();
            $target.find("input:eq(0)").focus();
        }
    });

    /* Handles validating using jQuery validate.
     */
    allPrevBtn.click(function () {
        var curStep = $(this).closest(".setup-content"),
            curStepBtn = curStep.attr("id"),
            prevStepWizard = $('div.setup-panel div a[href="#' + curStepBtn + '"]')
                .parent()
                .prev()
                .children("a"),
            curInputs = curStep.find("input"),
            isValid = false;

        prevStepWizard.removeClass("disabled").trigger("click");
    });

    allNextBtn.click(function () {
        var curStep = $(this).closest(".setup-content"),
        curStepBtn = curStep.attr("id"),
        nextStepWizard = $('div.setup-panel div a[href="#' + curStepBtn + '"]')
            .parent()
            .next()
            .children("a"),
        curInputs = curStep.find("input"),
        isValid = true;

        //Loop through all inputs in this form group and validate them.
        for (var i = 0; i < curInputs.length; i++) {
            if (!$(curInputs[i]).valid()) {
                isValid = false;
            }
        }

        if (isValid) {
            //Progress to the next page.
            nextStepWizard.removeClass("disabled").trigger("click");
            // # # # AJAX REQUEST HERE # # #

            /*
                  Theoretically, in order to preserve the state of the form should the worst happen, we could use an ajax call that would look something like this:
                  
                  //Prepare the key-val pairs like a normal post request.
                  var fields = {};
                  for(var i= 0; i < curInputs.length; i++){
                    fields[$(curInputs[i]).attr("name")] = $(curInputs[i]).attr("name").val();
                  }
                  
                  $.post(
                      "location.php",
                      fields,
                      function(data){
                        //Silent success handler.
                      }                
                  );
                  
                  //The FINAL button on last page should have its own logic to finalize the enrolment.
                  */
        }
    });

    $("div.setup-panel div a.btn-primary").trigger("click");
});