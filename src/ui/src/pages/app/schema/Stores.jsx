import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListStore = () => {

    const schema = {
        module: 'store',
        title: 'Store',
        path: 'stores',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Name', field: 'name', type: 'link', sorting: true, searching: true },
            { text: 'Business Unit', field: 'businessUnitId', type: 'lookup', schema: { module: 'businessUnit' }, sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewStore = () => {
    const schema = {
        module: 'store',
        title: 'Store',
        path: 'stores',
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
                    { text: 'Name', field: 'name', fieldIcon: 'warehouse', type: 'label', width: 6 },
                    {
                        text: 'Business Unit', field: 'businessUnitId', type: 'lookup-link', width: 6,
                        schema: { module: 'businessUnit', path: 'businessunits' }
                    },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditStore = () => {
    const schema = {
        module: 'store',
        title: 'Store',
        path: 'stores',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'warehouse', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    {
                        text: 'Business Unit', field: 'businessUnitId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'businessUnit' }
                    },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddStore = () => {
    const schema = {
        module: 'store',
        title: 'Store',
        path: 'stores',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'warehouse', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    {
                        text: 'Business Unit', field: 'businessUnitId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'businessUnit' }
                    },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

