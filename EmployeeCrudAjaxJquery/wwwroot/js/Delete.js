function Delete(id) {
    if (confirm('Are you sure,You want to delete this record?')) {
        $.ajax({
            url: '/Ajax/Delete?id=' + id,
            success: function() {
                alert("Record Deleted!");
                ShowEmployeeData();
            },
            error: function() {
                alert("Data can't be deleted");
            }
        });
    }
}
