var table;

$(document).ready(function () {
    table = $('#studentDataTable').DataTable({
        "ajax": {
            url: "/Home/Data",
            type: "GET",
            datatype: "json"
        },
        columns: [
            { data: 'FirstName' },
            { data: 'LastName' },
            { data: 'Email' },
            { data: 'Address' },
            { data: 'Gender' },
            {
                "mData": null,
                "bSortable": false,
                "mRender": function (o) {
                    return `<button class="btn btn-primary m-1" id="editBtn` + o.id + `" onclick="edit(${o.id})">
                            <span><i class="fas fa-edit"></i></span>
                            </button><button class="btn btn-primary m-1" id="deleteBtn` + o.id + `" onclick="deleteRow(${o.id},this)">
                            <span><i class="fa-solid fa-trash"></i></span></button>`;
                }
            }

        ],
        "pageLength": 15
    });
})

console.log(table)