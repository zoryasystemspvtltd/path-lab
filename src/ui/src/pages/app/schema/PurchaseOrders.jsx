import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListPurchaseOrder = () => {

    const schema = {
        module: 'purchaseOrder',
        title: 'Purchase Order',
        path: 'purchaseorders',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'PO Number', field: 'id', type: 'link', sorting: true, searching: true },
            { text: 'Vendor', field: 'vendorId', type: 'lookup', schema: { module: 'vendor' }, sorting: true, searching: true },
            { text: 'Status', field: 'status', type: 'text', sorting: true, searching: true },
            { text: 'Date', field: 'date', type: 'date', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewPurchaseOrder = () => {
    const schema = {
        module: 'purchaseOrder',
        title: 'Purchase Order',
        path: 'purchaseorders',
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
                    { text: 'PO Number', field: 'id', fieldIcon: 'file-invoice', type: 'label', width: 6 },
                    {
                        text: 'Vendor', field: 'vendorId', type: 'lookup-link', width: 6,
                        schema: { module: 'vendor', path: 'vendors' }
                    },
                    { text: 'Status', field: 'status', type: 'label', width: 6 },
                    { text: 'Date', field: 'date', type: 'label', width: 6 },
                ]
            },
            {
                type: "area", width: 12
                , fields: [
                    {
                        type: 'module-relation',
                        schema: {
                            module: 'poItem',
                            relationKey: "poId",
                            title: 'PO Items',
                            path: 'poitems',
                            paging: true,
                            searching: true,
                            editing: false,
                            adding: false,
                            fields: [
                                { text: 'Item', field: 'itemId', type: 'lookup', schema: { module: 'itemMaster' }, sorting: true, searching: true, },
                                { text: 'Quantity', field: 'quantity', type: 'text', sorting: false, searching: false },
                                { text: 'Price', field: 'price', type: 'text', sorting: false, searching: false },
                            ]
                        },
                    }
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditPurchaseOrder = () => {
    const schema = {
        module: 'purchaseOrder',
        title: 'Purchase Order',
        path: 'purchaseorders',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Vendor', field: 'vendorId', fieldIcon: 'truck', type: 'lookup', required: true, width: 6,
                        schema: { module: 'vendor' }
                    },
                    { text: 'Status', field: 'status', fieldIcon: 'circle-check', placeholder: 'Status here...', type: 'text', required: true, width: 6 },
                    { text: 'Date', field: 'date', fieldIcon: 'calendar', placeholder: 'Date here...', type: 'date', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddPurchaseOrder = () => {
    const schema = {
        module: 'purchaseOrder',
        title: 'Purchase Order',
        path: 'purchaseorders',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Vendor', field: 'vendorId', fieldIcon: 'truck', type: 'lookup', required: true, width: 6,
                        schema: { module: 'vendor' }
                    },
                    { text: 'Status', field: 'status', fieldIcon: 'circle-check', placeholder: 'Status here...', type: 'text', required: true, width: 6 },
                    { text: 'Date', field: 'date', fieldIcon: 'calendar', placeholder: 'Date here...', type: 'date', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

