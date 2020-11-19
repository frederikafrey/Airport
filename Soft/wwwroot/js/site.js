// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function () {
    //var e = document.getElementById("dd1").onchange(alert("aaa") );
    //var strUser = e.value;
    //alert(strUser);
    $("#dd1").bind("change", function () {
        var dID = $(this).val();
        $.getJSON("../Flights/Create/LoadPhysiansByDepartment", { deptId: dID },
                function (data) {
                    var select = $("#dd2");
                    select.empty();
                    select.append($('<option/>', {
                        value: 0,
                        text: "Select a Physian"
                    }));
                    $.each(data, function (index, itemData) {
                        select.append($('<option/>', {
                            value: itemData.Value,
                            text: itemData.Text
                        }));
                    });
                });
        alert(dID);
    });
}
   
    //document.getElementById("dd1").change(function () { alert("aaa")})
        //$("#dd1").change(function () {
        //    alert("aaa")
            //var dID = $(this).val();
            //$.getJSON("https://localhost:44361/Test/Tests/LoadPhysiansByDepartment", { deptId: dID },
            //    function (data) {
            //        var select = $("#dd2");
            //        select.empty();
            //        select.append($('<option/>', {
            //            value: 0,
            //            text: "Select a Physian"
            //        }));
            //        $.each(data, function (index, itemData) {
            //            select.append($('<option/>', {
            //                value: itemData.Value,
            //                text: itemData.Text
            //            }));
            //        });
            //    });
        //});
    
);
