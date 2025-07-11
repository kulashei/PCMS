
function onRowInserted(e) {
    DevExpress.ui.notify("Record Saved successfully", "success", 1000);
}

function onRowUpdated(e) {
    DevExpress.ui.notify("Record Updated successfully", "success", 1000);
}

function onRowRemoved(e) {
    DevExpress.ui.notify("Record Deleted successfully", "success", 1000);
}

// function onGridError(e){
//     if(e.error && e.error.message) {
//         DevExpress.ui.notify(e.error.message, "error", 1000); 
//     }
// }

