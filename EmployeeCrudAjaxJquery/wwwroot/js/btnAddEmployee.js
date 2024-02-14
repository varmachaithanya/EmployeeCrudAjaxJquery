$('#btnAddEmployee').click(function () {
    clearTextBox();
    $('#EmployeeMadal').modal('show');
    $('#empId').hide();
    $('#AddEmployee').show();
    $('#btnUpdate').hide();
    $('#empHeading').text('Add Employee');

});
