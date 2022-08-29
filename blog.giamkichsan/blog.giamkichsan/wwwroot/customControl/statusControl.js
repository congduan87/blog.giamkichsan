let statusControl = {
    className: 'custom-status',
    init: function (properties, event) {
        statusControl.element = statusControl.showControl(properties);
        statusControl.setEventAction(statusControl.element, event);
        return statusControl.element;
    },
    getClass: function (properties) {
        let classControl = '';
        if (properties.dataClasses && properties.dataClasses.length > 0) {
            for (var index = 0; index < properties.dataClasses.length; index++) {
                if (properties.value && properties.value == properties.dataClasses[index].key) {
                    classControl = properties.dataClasses[index].text;
                    break;
                }
            }
        }
        return classControl;
    },
    showControl: function (properties) {
        return $('<button type="button" class="btn btn-round btn-xs ' + getClass(properties) + '" value="' + properties.value + '">' + properties.text + '</button>');
    },
    setEventAction: function ($item, event) {
        if (event, event.click) {
            $item.bind('click', function (e) {
                event.click(e);
            })
        }
    }
}

//var controlStatus1 = function () {
//    this.type = enumType.typeStatusControl;
//    this.value = '1';
//    this.text = 'Đã xử lý';
//    this.dataClasses = [{ key: '1', text: 'btn-success' }, { key: '2', text: 'btn-warning' }];
//}
//var controlStatus2 = function () {
//    this.type = enumType.typeStatusControl;
//    this.value = '2';
//    this.text = 'Đang xử lý';
//    this.dataClasses = [{ key: '1', text: 'btn-success' }, { key: '2', text: 'btn-warning' }];
//}
//statusControl.init(controlStatus1);
//statusControl.init(controlStatus2);