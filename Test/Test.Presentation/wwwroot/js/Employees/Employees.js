function callEmployes() {
    $.ajax({
        url: "https://localhost:44378/api/Employees",
        success: function (result) {
            if (result.result)
                fillTable(result.data);
        }
    });
}

function callEmployeById(id) {
    $.ajax({
        url: "https://localhost:44378/api/Employees/" + id,
        success: function (result) {
            if (result.result)
                fillTable(result.data);
        }
    });
}

function fillTable(dataSet) {
    table = $('#employeesTable').DataTable();
    table.destroy();
    $('#employeesTable').DataTable({
        paging: false,
        searching: false,
        data: dataSet,
        columns: [
            { "data": "id" },
            { "data": "name" },
            { "data": "contractTypeName" },
            { "data": "roleId" },
            { "data": "roleName" },
            { "data": "roleDescription" },
            { "data": "hourlySalary" },
            { "data": "monthlySalary" },
            { "data": "totalSalary" }
        ]
    });
}




$(document).ready(function () {
    $("#btnGetEmployees").click(function () {
        if ($('#txtGetEmployees').val() === "")
            callEmployes();
        else
            callEmployeById($("#txtGetEmployees").val());
    });

    callEmployes();
});