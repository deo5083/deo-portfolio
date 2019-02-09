function selectClicked(option){
    
    document.getElementById("MainContent_HiddenField_selectDegree").value = option;
    document.getElementById("MainContent_HiddenButton_selectDegree").click();
    
}

function divClicked(option) {
    
    if (option != "") {

        document.getElementById("label_div").classList.remove("text-center");

        var divs = document.getElementsByClassName("custom_divs");

        for (var i = 0; i < divs.length; i++) {
            if (divs[i].id == option) {
                divs[i].classList.remove("custom_active_div");
            }

        }
        
        document.getElementById(option).classList.add("custom_active_div");
        
        removeAttribute(option);


    }


}

function removeAttribute(option) {

    var courses = document.getElementsByClassName("courseLists");
    
    for (var i = 0; i < courses.length; i++) {
        if (courses[i].id == "Panel_" + option) {
            courses[i].removeAttribute("style");
        }
        
    }
}

