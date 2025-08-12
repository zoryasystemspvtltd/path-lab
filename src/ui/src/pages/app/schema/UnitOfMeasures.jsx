import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListUnitOfMeasure = () => {

    const schema = {
        module: 'unitOfMeasure',
        title: 'UnitOfMeasure',
        path: 'unitOfMeasures',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Name', field: 'name', type: 'link', sorting: true, searching: true },
            { text: 'Alias', field: 'code', type: 'text', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewUnitOfMeasure = () => {
    const schema = {
        module: 'unitOfMeasure',
        title: 'UnitOfMeasure',
        path: 'unitOfMeasures',
        showBreadcrumbs: true,
        editing: true,
        adding: false,
        deleting: true,
        back: true,
        readonly: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', type: 'label', width: 6 },
                    { text: 'Alias', field: 'code', type: 'label', width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditUnitOfMeasure = () => {
    const schema = {
        module: 'unitOfMeasure',
        title: 'UnitOfMeasure',
        path: 'unitOfMeasures',
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddUnitOfMeasure = () => {
    const schema = {
        module: 'unitOfMeasure',
        title: 'UnitOfMeasure',
        path: 'unitOfMeasures',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}