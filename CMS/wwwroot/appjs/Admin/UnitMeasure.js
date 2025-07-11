
let unitMeasureGrid;
function onUnitMeasureGridInitialize(e){
     unitMeasureGrid = e.component;
}

function saveUnitMeasure(){
    unitMeasureGrid.saveEditData()  
}

function cancelUnitMeasure(){
    unitMeasureGrid.cancelEditData()
}

function refreshGrid(){
    unitMeasureGrid.refresh()
}

// function UniqueUnitCodeCheck(e){
//     var duplicate = false;
//     var data = unitMeasureGrid.getDataSource().items();
//    
//     var duplicate = data.some(function (item) {
//        return item.UnitCode === e.value;
//     });
//     return duplicate;
// }