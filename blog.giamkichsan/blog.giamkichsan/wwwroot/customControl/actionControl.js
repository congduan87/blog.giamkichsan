let actionControl = {
    range: 4,
    className: 'custom-action',
    init: function (properties, event) {
        actionControl.element = actionControl.setAction(properties);
        actionControl.setEventAction(actionControl.element, event);
        return actionControl.element;
    },
    getClass: function (type) {
        switch (type) {
            case enumType.typeButtonView: return 'btn-primary';
            case enumType.typeButtonCreate: return 'btn-info';
            case enumType.typeButtonUpdate: return 'btn-warning';
            case enumType.typeButtonDelete: return 'btn-danger';
            case enumType.typeButtonActive: return 'btn-dark';
            case enumType.typeButtonUnActive: return 'btn-dark';
            case enumType.typeButtonReport: return 'btn-dark';
            default: return '';
        }
    },
    getChildClass: function (type) {
        switch (type) {
            case enumType.typeButtonView: return 'fa-eye';
            case enumType.typeButtonCreate: return 'fa-plus';
            case enumType.typeButtonUpdate: return 'fa-pencil';
            case enumType.typeButtonDelete: return 'fa-trash-o';
            case enumType.typeButtonActive: return 'fa-lock';
            case enumType.typeButtonUnActive: return 'fa-unlock';
            case enumType.typeButtonReport: return 'fa-print';
            default: return '';
        }
    },
    getName: function (type) {
        switch (type) {
            case enumType.typeButtonView: return 'Xem';
            case enumType.typeButtonCreate: return 'Thêm mới';
            case enumType.typeButtonUpdate: return 'Chỉnh sửa';
            case enumType.typeButtonDelete: return 'Xóa';
            case enumType.typeButtonActive: return 'Hoạt động';
            case enumType.typeButtonUnActive: return 'Không hoạt động';
            case enumType.typeButtonReport: return 'Báo cáo';
            default: return '';
        }
    },
    showWithinRange: function (type, href) {
        return $('<a href="' + href + '" class="btn ' + actionControl.getClass(type) + ' btn-xs" title="' + actionControl.getName(type) + '"><i class="fa ' + actionControl.getChildClass(type) + '"></i></a>');
    },
    showWithRange: function (type, href) {
        return $('<a href="' + href + '" class="dropdown-item"><i class="fa ' + actionControl.getChildClass(type) + '">' + actionControl.getName(type) + '</i></a>');
    },
    showDOMButtonGroup: function () {
        actionControl.DOMButtonGroup = $('<div type="button" class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></div>');
    },
    showDOMButtonDown: function () {
        actionControl.DOMButtonDown = $('<div class="dropdown-menu"></div>');
    },
    showDOMDivider: function () {
        return $('<div class="dropdown-divider"></div>');
    },
    setAction: function (properties) {
        if (properties.type == enumType.typButtonGroup || properties.dataControl || properties.dataControl.length == 0) {
            return actionControl.showWithinRange(properties.type, properties.href);
        }
        else {
            let $parent = $('<div class="' + actionControl.className + '"></div>');
            for (var index = 0; index < properties.dataControls; index++) {
                var current = actionControl.setChildAction(properties.dataControls[index].propertiesControl, $parent);
                actionControl.setEventAction(current, properties.dataControls[index].eventControl);
            }
            return $parent;
        }
    },
    setChildAction: function (properties, index, $parent) {
        if (index == actionControl.range) {
            actionControl.showDOMButtonGroup();
            actionControl.showDOMButtonDown();
            actionControl.DOMButtonGroup.appendTo($parent);
            actionControl.DOMButtonDown.appendTo($parent);
        }

        if (index > actionControl.range) {
            actionControl.showDOMDivider().appendTo(actionControl.DOMButtonDown);
        }

        return actionControl.showWithRange(properties.type, properties.href).appendTo(actionControl.DOMButtonDown);
    },
    setEventAction: function ($item, event) {
        if (event, event.click) {
            $item.bind('click', function (e) {
                event.click(e);
            })
        }
    }
}

//var controlAction = function () {
//    this.type = enumType.typButtonGroup;
//    this.value = '';
//    this.text = '';
//    this.href = '';
//    this.dataClasses = [];
//    this.dataItems = [];
//    this.dataControls = [
//        { propertiesControl: { type: enumType.typeButtonView, href: 'view.html', }, eventControl: { click: function () { }} },
//        { propertiesControl: { type: enumType.typeButtonUpdate, href: 'update.html', }, eventControl: { click: function () { }} },
//        { propertiesControl: { type: enumType.typeButtonDelete, href: '', }, eventControl: { click: function () { }} },
//        { propertiesControl: { type: enumType.typeButtonActive, href: '', }, eventControl: { click: function () { }} },
//        { propertiesControl: { type: enumType.typeButtonReport, href: '', }, eventControl: { click: function () { }} },
//    ];
//}
//actionControl.init(controlAction);