import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListPOItem = () => {

    const schema = {
        module: 'poItem',
        title: 'PO Item',
        path: 'poitems',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Purchase Order', field: 'poId', type: 'lookup', schema: { module: 'purchaseOrder' }, sorting: true, searching: true },
            { text: 'Item', field: 'itemId', type: 'lookup', schema: { module: 'itemMaster' }, sorting: true, searching: true },
            { text: 'Quantity', field: 'quantity', type: 'text', sorting: true, searching: true },
            { text: 'Price', field: 'price', type: 'text', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewPOItem = () => {
    const schema = {
        module: 'poItem',
        title: 'PO Item',
        path: 'poitems',
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
                        text: 'Purchase Order', field: 'poId', type: 'lookup-link', width: 6,
                        schema: { module: 'purchaseOrder', path: 'purchaseorders' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup-link', width: 6,
                        schema: { module: 'itemMaster', path: 'itemmasters' }
                    },
                    { text: 'Quantity', field: 'quantity', type: 'label', width: 6 },
                    { text: 'Price', field: 'price', type: 'label', width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditPOItem = () => {
    const schema = {
        module: 'poItem',
        title: 'PO Item',
        path: 'poitems',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Purchase Order', field: 'poId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'purchaseOrder' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'itemMaster' }
                    },
                    { text: 'Quantity', field: 'quantity', fieldIcon: 'hashtag', placeholder: 'Quantity here...', type: 'number', required: true, width: 6 },
                    { text: 'Price', field: 'price', fieldIcon: 'dollar-sign', placeholder: 'Price here...', type: 'number', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddPOItem = () => {
    const schema = {
        module: 'poItem',
        title: 'PO Item',
        path: 'poitems',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Purchase Order', field: 'poId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'purchaseOrder' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'itemMaster' }
                    },
                    { text: 'Quantity', field: 'quantity', fieldIcon: 'hashtag', placeholder: 'Quantity here...', type: 'number', required: true, width: 6 },
                    { text: 'Price', field: 'price', fieldIcon: 'dollar-sign', placeholder: 'Price here...', type: 'number', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

