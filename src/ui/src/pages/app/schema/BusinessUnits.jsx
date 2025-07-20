import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListBusinessUnit = () => {

    const schema = {
        module: 'businessunit',
        title: 'Business Unit',
        path: 'businessunits',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Name', field: 'name', type: 'link', sorting: true, searching: true },
            { text: 'Alias', field: 'code', type: 'text', sorting: true, searching: true },
            { text: 'Enterprise', field: 'enterpriseId', type: 'lookup', schema: { module: 'enterprise' }, sorting: true, searching: true },
            { text: 'Type', field: 'type', type: 'text', sorting: true, searching: true }
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewBusinessUnit = () => {
    const schema = {
        module: 'businessunit',
        title: 'Business Unit',
        path: 'businessunits',
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
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                    {
                        text: 'Enterprise', field: 'enterpriseId', type: 'lookup-link', required: true, width: 6,
                        schema: { module: 'enterprise', path: 'enterprises' }
                    },
                    { text: 'Type', field: 'type', type: 'text', required: true, width: 6 }
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditBusinessUnit = () => {
    const schema = {
        module: 'businessunit',
        title: 'Business Unit',
        path: 'businessunits',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                    {
                        text: 'Enterprise', field: 'enterpriseId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'enterprise' }
                    },
                    { text: 'Type', field: 'type', placeholder: 'Type here...', type: 'text', required: true, width: 6 }
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddBusinessUnit = () => {
    const schema = {
        module: 'businessunit',
        title: 'Business Unit',
        path: 'businessunits',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                    {
                        text: 'Enterprise', field: 'enterpriseId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'enterprise' }
                    },
                    { text: 'Type', field: 'type', placeholder: 'Type here...', type: 'text', required: true, width: 6 }
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}