import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListEnterprise = () => {

    const schema = {
        module: 'enterprise',
        title: 'Enterprise',
        path: 'enterprises',
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

export const ViewEnterprise = () => {
    const schema = {
        module: 'enterprise',
        title: 'Enterprise',
        path: 'enterprises',
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
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', type: 'label', width: 6 },
                    { text: 'Alias', field: 'code', type: 'label', width: 6 },
                    { text: 'Description', field: 'description', type: 'label', width: 12 },
                ]
            },
            {
                type: "area", width: 12
                , fields: [
                    {
                        type: 'module-relation',
                        schema: {
                            module: 'businessUnit',
                            relationKey: "EnterpriseId",
                            title: 'Business Unit',
                            path: 'businessunits',
                            paging: true,
                            searching: true,
                            editing: false,
                            adding: false,
                            fields: [
                                { text: 'Name', field: 'name', type: 'link', sorting: true, searching: true, },
                                { text: 'Description', field: 'description', type: 'text', sorting: false, searching: false },
                            ]
                        },
                    }
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditEnterprise = () => {
    const schema = {
        module: 'enterprise',
        title: 'Enterprise',
        path: 'enterprises',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                    { text: 'Description', field: 'description', type: 'textarea', required: false, width: 12 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddEnterprise = () => {
    const schema = {
        module: 'enterprise',
        title: 'Enterprise',
        path: 'enterprises',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                    { text: 'Description', field: 'description', type: 'textarea', required: false, width: 12 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}