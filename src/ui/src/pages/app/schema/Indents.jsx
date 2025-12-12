import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListIndent = () => {

    const schema = {
        module: 'indent',
        title: 'Indent',
        path: 'indents',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Indent Number', field: 'id', type: 'link', sorting: true, searching: true },
            { text: 'Business Unit', field: 'businessUnitId', type: 'lookup', schema: { module: 'businessUnit' }, sorting: true, searching: true },
            { text: 'User', field: 'userId', type: 'lookup', schema: { module: 'user' }, sorting: true, searching: true },
            { text: 'Date', field: 'date', type: 'date', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewIndent = () => {
    const schema = {
        module: 'indent',
        title: 'Indent',
        path: 'indents',
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
                    { text: 'Indent Number', field: 'id', fieldIcon: 'file-lines', type: 'label', width: 6 },
                    {
                        text: 'Business Unit', field: 'businessUnitId', type: 'lookup-link', width: 6,
                        schema: { module: 'businessUnit', path: 'businessunits' }
                    },
                    {
                        text: 'User', field: 'userId', type: 'lookup-link', width: 6,
                        schema: { module: 'user', path: 'users' }
                    },
                    { text: 'Date', field: 'date', type: 'label', width: 6 },
                ]
            },
            {
                type: "area", width: 12
                , fields: [
                    {
                        type: 'module-relation',
                        schema: {
                            module: 'indentItem',
                            relationKey: "indentId",
                            title: 'Indent Items',
                            path: 'indentitems',
                            paging: true,
                            searching: true,
                            editing: false,
                            adding: false,
                            fields: [
                                { text: 'Item', field: 'itemId', type: 'lookup', schema: { module: 'itemMaster' }, sorting: true, searching: true, },
                                { text: 'Quantity', field: 'quantity', type: 'text', sorting: false, searching: false },
                            ]
                        },
                    }
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditIndent = () => {
    const schema = {
        module: 'indent',
        title: 'Indent',
        path: 'indents',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Business Unit', field: 'businessUnitId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'businessUnit' }
                    },
                    {
                        text: 'User', field: 'userId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'user' }
                    },
                    { text: 'Date', field: 'date', fieldIcon: 'calendar', placeholder: 'Date here...', type: 'date', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddIndent = () => {
    const schema = {
        module: 'indent',
        title: 'Indent',
        path: 'indents',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Business Unit', field: 'businessUnitId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'businessUnit' }
                    },
                    {
                        text: 'User', field: 'userId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'user' }
                    },
                    { text: 'Date', field: 'date', fieldIcon: 'calendar', placeholder: 'Date here...', type: 'date', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

