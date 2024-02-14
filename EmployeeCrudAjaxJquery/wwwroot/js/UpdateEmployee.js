function UpdateEmployee() {
    var objdata = {
        Id: $('#Id').val(),
        Name: $('#Name').val(),
        City: $('#City').val(),
        State: $('#State').val(),
        Salary: $('#Salary').val()
    };
    $.ajax({
        url: '/Ajax/Update',
        type: 'Post',
        data: objdata,
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function() {
            alert('Data Saved');
            clearTextBox();
            ShowEmployeeData();
            HideModalPopUp();
        },
        error: function() {
            alert("Data can't Saved");
        }
    });

}
