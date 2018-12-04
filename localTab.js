
(function () { 
    //The Details Object used to store data in the LocalStorage 
    var Details = { 
    FirstName: "", 
    LastName: "",
    Email: "",
    PhoneNo: "",
    Address: "", 
    City:"", 
    Province: "",
    PostalCode: "",
    VehicleMake: "",
    VehicleModel: "",
    VehicleYear: ""
    };
    
    var checkLoadedData = false;
    //JavaScript object containing methods for LocalStorage management 
    var applogic = {
    //Clear All Entries, by reading all elements having class as c1 
    clearuielements: function () { 
        var inputs = document.getElementsByClassName("c1"); 
        for (i = 0; i < inputs.length; i++) { 
            inputs[i].value = ""; 
        } 
    },
    //Save Entry in the Localstorage by eading values entered in the 
    //UI 
    saveitem: function () { 
        var lscount = localStorage.length; //Get the Length of the LocalStorage
        //Read all elements on UI using class name 
        if(validateUpload()){
            var inputs = document.getElementsByClassName("c1"); 
                Details.FirstName = inputs[0].value; 
                Details.LastName = inputs[1].value; 
                Details.Email = inputs[2].value; 
                Details.PhoneNo = inputs[3].value; 
                Details.Address = inputs[4].value; 
                Details.City = inputs[5].value; 
                Details.Province = inputs[6].value; 
                Details.PostalCode = inputs[7].value; 
                Details.VehicleMake = inputs[8].value;
                Details.VehicleModel = inputs[9].value;
                Details.VehicleYear = inputs[10].value;
        //Convert the object into JSON and store it in LocalStorage 
                localStorage.setItem("Details_" + lscount, JSON.stringify(Details)); 
        //Reload the Page 
                checkLoadedData = true;
                location.reload(); 
        } else{

        }   
    },
    //Method to Read Data from the local Storage 
    loaddata: function () { 
        var datacount = localStorage.length; 
        if (datacount > 0 ) 
        {
            var render = "<table border='1' id ='myTable'>"; 
                render += "<tr><th>FirstName</th><th>LastName</th><th>Email</th><th>PhoneNo</th><th>Address</th><th>City</th><th>Province</th><th>PostalCode</th><th>VehicleMake</th><th>VehicleModel</th><th>VehicleYear</th><th>URL</th></tr>"; 
                for (i = 0; i < datacount; i++) { 
                    var key = localStorage.key(i); //Get  the Key 
                    var Details = localStorage.getItem(key); //Get Data from Key 
                    var data = JSON.parse(Details); //Parse the Data back into the object 
                    var urlLink = 'http://www.jdpower.com/cars/' + data.VehicleMake + '/' + data.VehicleModel + '/' + data.VehicleYear;
                    render += "<tr><td>" + data.FirstName + "</td><td>" + data.LastName + " </td>"; 
                    render += "<td>" + data.Email + "</td>"; 
                    render += "<td>" + data.PhoneNo + "</td>"; 
                    render += "<td>" + data.Address + "</td>"; 
                    render += "<td>" + data.City + "</td>"; 
                    render += "<td>" + data.Province + "</td>"; 
                    render += "<td>" + data.PostalCode + "</td>"; 
                    render += "<td>" + data.VehicleMake + "</td>";
                    render += "<td>" + data.VehicleModel + "</td>";
                    render += "<td>" + data.VehicleYear + "</td>";
                    render += "<td><a href ="+ urlLink + ">" + 'http://www.jdpower.com/cars/' + data.VehicleMake + '/' + data.VehicleModel + '/' + data.VehicleYear + "</a></td></tr>";
            }
            render+="</table>"; 
            dvcontainer.innerHTML = render; 
    }
    },
    loadOnLoad: function(){
        var datacount = localStorage.length; 
        checkLoadedData = true;
        if (datacount > 0 ) 
        {
            var render = "<table border='1' id ='myTable'>"; 
            render += "<tr><th>FirstName</th><th>LastName</th><th>Email</th><th>PhoneNo</th><th>Address</th><th>City</th><th>Province</th><th>PostalCode</th><th>VehicleMake</th><th>VehicleModel</th><th>VehicleYear</th><th>URL</th></tr>"; 
            for (i = 0; i < datacount - 1; i++) { 
                var key = localStorage.key(i); //Get  the Key 
                var Details = localStorage.getItem(key); //Get Data from Key 
                var data = JSON.parse(Details); //Parse the Data back into the object 
                var urlLink = 'http://www.jdpower.com/cars/' + data.VehicleMake + '/' + data.VehicleModel + '/' + data.VehicleYear;
                render += "<tr><td>" + data.FirstName + "</td><td>" + data.LastName + " </td>"; 
                render += "<td>" + data.Email + "</td>"; 
                render += "<td>" + data.PhoneNo + "</td>"; 
                render += "<td>" + data.Address + "</td>"; 
                render += "<td>" + data.City + "</td>"; 
                render += "<td>" + data.Province + "</td>"; 
                render += "<td>" + data.PostalCode + "</td>"; 
                render += "<td>" + data.VehicleMake + "</td>";
                render += "<td>" + data.VehicleModel + "</td>";
                render += "<td>" + data.VehicleYear + "</td>";
                render += "<td><a href ="+ urlLink + ">" + 'http://www.jdpower.com/cars/' + data.VehicleMake + '/' + data.VehicleModel + '/' + data.VehicleYear + "</a></td></tr>"; 
            }
            render+="</table>"; 
            dvcontainer.innerHTML = render;
        }   
    },
    //Method to Clear Storage 
    clearstorage: function () { 
        var storagecount = localStorage.length; //Get the Storage Count 
        if (storagecount > 0) 
        { 
            for (i = 0; i < storagecount; i++) { 
                localStorage.clear(); 
            } 
        } 
        window.location.reload(); 
    }
    };
    //Save object into the localstorage 
    var btnsave = document.getElementById('btnsave'); 
    btnupload.addEventListener('click', applogic.saveitem, false); 
    //Clear all UI Elements 
    var btnclear = document.getElementById('btnclear'); 
    btnclear.addEventListener('click', applogic.clearuielements, false); 
    //Clear LocalStorage 
    var btnclearstorage = document.getElementById('btnclearstorage'); 
    btnclearstorage.addEventListener('click', applogic.clearstorage, false); 
    //On Load of window load data from local storage 
    window.onload = function () { 
        if(!checkLoadedData){
            applogic.loaddata(); 
        }
    
    }; 
    })(); 