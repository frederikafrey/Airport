$(document).ready(function () {
    $('.selectpicker').selectpicker({
        liveSearch: true,
        showSubtext: true
        //maxOptions: 5
    });
});

function DropDownUpdater(dropDownOne, dropDownTwo, location) {
    var selectedValue = $(dropDownOne).val();
    var itemsSelect = $(dropDownTwo);
    itemsSelect.empty();

    if (selectedValue == null) return;

    $.ajax({
        type: "POST",
        url: location,
        beforeSend: function(token) {
            token.setRequestHeader("HeaderToken", $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: selectedValue,
        contentType: "json; charset=utf-8",
        success: function(items) {
            if (items == null && jQuery.isEmptyObject(items)) return;

            itemsSelect.append($('<option/>',
                {
                    value: null,
                    text: ""
                }));

            $.each(items,
                function(index, item) {
                    itemsSelect.append("<option value='" + item.text + "'>" + item.text + "</option>");
                }
            );
        },
        failure: function(response) {
            alert(response);
        }
    });
}

