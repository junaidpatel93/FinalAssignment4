function validatePhone(){
    var num = $('#phone').val();
    var pattern = /((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}/;
    
    if(!pattern.test(num)){
        $('#phone').css("border", "red solid 1px");
        return false;
    }else{
        $('#phone').css("border", "");
        return true;
    }
}

function validateFirstName(){
    var fn = $('#firstName').val();
    if(fn == "" || fn == undefined){
        $('#firstName').css("border", "red solid 1px");
        return false;
    }else{
        $('#firstName').css("border", "");
        return true;
    }
}

function validateLastName(){
    var ln = $('#lastName').val();
    if(ln == "" || ln == undefined){
        $('#lastName').css("border", "red solid 1px");
        return false;
    }else{
        $('#lastName').css("border", "");
        return true;
    }
}

function validateEmail(){
    var email = $('#email').val();
    var regexEmail = /^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$/;
    if(!regexEmail.test(email)){
        $('#email').css("border", "red solid 1px");
        return false;
    }else{
        $('#email').css("border", "");
        return true;
    }
}

function validateAddress(){
    var ad = $('#address').val();
    if(ad == "" || ad == undefined){
        $('#address').css("border", "red solid 1px");
        return false;
    }else{
        $('#address').css("border", "");
        return true;
    }
}

function validateCity(){
    var city = $('#city').val();
    if(city == "" || city == undefined){
        $('#city').css("border", "red solid 1px");
        return false;
    }else{
        $('#city').css("border", "");
        return true;
    }
}

function validatePostalCode(){
    var pc = $('#postalCode').val();
    var pcregex = /^[A-Za-z]\d[A-Za-z][ -]?\d[A-Za-z]\d$/;
    if(pc == "" || pc == undefined || !pcregex.test(pc)){
        $('#postalCode').css("border", "red solid 1px");
        return false;
    }else{
        $('#postalCode').css("border", "");
        return true;
    }
}

function validateVehicleMake(){
    var make = $('#make').val();
    if(make == "Ford" || make == "Chrysler" || make == "Cadillac" || make == "Lamborghini" 
    || make == "Ferrari" || make == "Gmc"){
        $('#make').css("border", "");
        return true;
    }else{
        $('#make').css("border", "red solid 1px");
        return false;
    }
}

function validateVehicleModel(){
    var model = $('#model').val();
    var make = $('#make').val();
    if(model == "" || make == ""){
        $('#model').css("border", "red solid 1px");
        return false;
    }
    else if(make == "Ford"){
        var arr = ["Mustang", "Ecosport", "Edge", "Escape", "Expedition", "Explorer", "Fiesta", "Focus"];
        if($.inArray(model, arr) > -1){
            $('#model').css("border", "");
            $('#model-error').addClass('hide'); 
            return true;
        }else{
            $('#model').css("border", "red solid 1px");
        return false;
        }
    }
    else if(make == "Chrysler"){
        var arr = ["300", "Pacifica"];
        if($.inArray(model, arr) > -1){
            $('#model').css("border", "");
            $('#model-error').addClass('hide'); 
            return true;
        }else{
            $('#model').css("border", "red solid 1px");
        return false;
        }
    }
    else if(make == "Cadillac"){
        var arr = ["Ats", "Cts", "Escalade", "Xts", "Expedition"];
        if($.inArray(model, arr) > -1){
            $('#model').css("border", "");
            $('#model-error').addClass('hide'); 
            return true;
        }else{
            $('#model').css("border", "red solid 1px");
        return false;
        }
    }
    else if(make == "Lamborghini"){
        var arr = ["Aventador", "Huracan"];
        if($.inArray(model, arr) > -1){
            $('#model').css("border", "");
            $('#model-error').addClass('hide'); 
            return true;
        }else{
            $('#model').css("border", "red solid 1px");
        return false;
        }
    }
    else if(make == "Ferrari"){
        var arr = ["488-Gtb", "488-Spider", "California-T"];
        if($.inArray(model, arr) > -1){
            $('#model').css("border", "");
            $('#model-error').addClass('hide'); 
            return true;
        }else{
            $('#model').css("border", "red solid 1px");
        return false;
        }
    }
    else if(make == "Gmc"){
        var arr = ["Acadia", "Canyon", "Sierra-1500", "Escape", "Yukon", "Terrain"];
        if($.inArray(model, arr) > -1){
            $('#model').css("border", "");
            $('#model-error').addClass('hide'); 
            return true;
        }else{
            $('#model').css("border", "red solid 1px");
        return false;
        }
    }else{
        $('#model').css("border", "red solid 1px");
        return false;
    }
}

function validateVehicleYear(){
    var year = $('#year').val();
    if(year == "" || year.length != 4 || year == undefined || year.isNaN || year < 1999 || year > 2018){
        $('#year').css("border", "red solid 1px");
        return false;
    }else{
        $('#year').css("border", "");
        return true;
    }
}

function validateUpload(){
    if(validateFirstName() && validateLastName() && validateEmail() && validateAddress() && validatePhone() 
    && validatePostalCode() && validateVehicleMake() && validateVehicleModel() && validateVehicleYear()){ 
    
        return true;
        
    
    }else{
        if(validateFirstName()){
            $('#fn-error').addClass('hide'); 
        }else{
            $('#fn-error').removeClass('hide');
        }
        if(validateLastName()){
            $('#ln-error').addClass('hide');  
        }else{
            $('#ln-error').removeClass('hide'); 
        }
        if(validateEmail()){
            $('#email-error').addClass('hide'); 
        }else{
            $('#email-error').removeClass('hide');
        }
        if(validatePhone()){
            $('#phone-error').addClass('hide'); 
        }else{
            $('#phone-error').removeClass('hide');
        }
        if(validateAddress()){
            $('#ad-error').addClass('hide'); 
        }else{
            $('#ad-error').removeClass('hide');
        }
        if(validateCity()){
            $('#city-error').addClass('hide'); 
        }else{
            $('#city-error').removeClass('hide');
        }
        if(validatePostalCode()){
            $('#pc-error').addClass('hide'); 
        }else{
            $('#pc-error').removeClass('hide');
        }
        if(validateVehicleMake()){
            $('#make-error').addClass('hide'); 
        }else{
            $('#make-error').removeClass('hide');
        }
        if(validateVehicleModel()){
            $('#model-error').addClass('hide'); 
        }else{
            $('#model-error').removeClass('hide');
        }
        if(validateVehicleYear()){
            $('#year-error').addClass('hide'); 
        }else{
            $('#year-error').removeClass('hide');
        }
        return false;
    }
}

function mySearch(){
    var input, filter, table, tr, i, txtValue;
  input = document.getElementById("myInput");
  filter = input.value.toUpperCase();
  table = document.getElementById("myTable");
  tr = table.getElementsByTagName("tr");
  for (i = 0; i < tr.length; i++) {
    var make = tr[i].getElementsByTagName("td")[8];
    var model = tr[i].getElementsByTagName("td")[9];
    var year = tr[i].getElementsByTagName("td")[10];
    if (make || model || year) {
      txtMake = make.textContent || make.innerText;
      txtModel = model.textContent || model.innerText;
      txtYear = year.textContent || year.innerText;
      if (txtMake.toUpperCase().indexOf(filter) > -1 || txtModel.toUpperCase().indexOf(filter) > -1 || txtYear.toUpperCase().indexOf(filter) > -1) {
        tr[i].style.display = "";
      } else {
        tr[i].style.display = "none";
      }
    }       
  }
}
