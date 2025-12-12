import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListIndentItem = () => {

    const schema = {
        module: 'indentItem',
        title: 'Indent Item',
        path: 'indentitems',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Indent', field: 'indentId', type: 'lookup', schema: { module: 'indent' }, sorting: true, searching: true },
            { text: 'Item', field: 'itemId', type: 'lookup', schema: { module: 'itemMaster' }, sorting: true, searching: true },
            { text: 'Quantity', field: 'quantity', type: 'text', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewIndentItem = () => {
    const schema = {
        module: 'indentItem',
        title: 'Indent Item',
        path: 'indentitems',
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
                    {
                        text: 'Indent', field: 'indentId', type: 'lookup-link', width: 6,
                        schema: { module: 'indent', path: 'indents' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup-link', width: 6,
                        schema: { module: 'itemMaster', path: 'itemmasters' }
                    },
                    { text: 'Quantity', field: 'quantity', type: 'label', width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditIndentItem = () => {
    const schema = {
        module: 'indentItem',
        title: 'Indent Item',
        path: 'indentitems',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Indent', field: 'indentId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'indent' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'itemMaster' }
                    },
                    { text: 'Quantity', field: 'quantity', fieldIcon: 'hashtag', placeholder: 'Quantity here...', type: 'number', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddIndentItem = () => {
    const schema = {
        module: 'indentItem',
        title: 'Indent Item',
        path: 'indentitems',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Indent', field: 'indentId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'indent' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'itemMaster' }
                    },
                    { text: 'Quantity', field: 'quantity', fieldIcon: 'hashtag', placeholder: 'Quantity here...', type: 'number', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

