function alert_success(msg, desc) {
    $.confirm({
        icon: 'fa fa-check-circle',
        title: msg,
        content: desc,
        type: 'green',
        typeAnimated: true,
        buttons: {
            OK: {
                text: 'OK',
                btnClass: 'btn-green',
                keys: ['enter', 'shift'],
                action: function () {
                }
            }
        }
    });
}

function alert_error(msg, desc) {
    $.confirm({
        icon: 'fa fa-exclamation-circle',
        title: msg,
        content: desc,
        type: 'red',
        typeAnimated: true,
        buttons: {
            OK: {
                text: 'OK',
                btnClass: 'btn-red',
                keys: ['enter', 'shift'],
                action: function () {
                }
            }
        }
    });
}

function ConfirmDialog(ConfirmText ,SuccessFunction) {
        $.confirm({
            icon: 'fa fa-question-circle',
            type: 'orange',
            title: 'Confirm!',
            content: ConfirmText,
            buttons: {
                Yes: {
                    text: 'Yes',
                    btnClass: 'btn-green',
                    keys: ['enter', 'shift'],
                    action: function () {
                        SuccessFunction();
                    }
                },
                No: {
                    text: 'No',
                    btnClass: 'btn-red',
                    keys: ['enter', 'shift'],
                    action: function () {

                    }
                }
            }
        });
    }

//function ConfirmDialogWithParam(ConfirmText, SuccessFunction, id) {
//    $.confirm({
//        icon: 'fa fa-question-circle',
//        type: 'orange',
//        title: 'Confirm!',
//        content: ConfirmText,
//        buttons: {
//            Yes: {
//                text: 'Yes',
//                btnClass: 'btn-green',
//                keys: ['enter', 'shift'],
//                action: function () {
//                    SuccessFunction(id);
//                }
//            },
//            No: {
//                text: 'No',
//                btnClass: 'btn-red',
//                keys: ['enter', 'shift'],
//                action: function () {

//                }
//            }
//        }
//    });
//}


