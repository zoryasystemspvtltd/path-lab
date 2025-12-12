import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListStockEntry = () => {

    const schema = {
        module: 'stockEntry',
        title: 'Stock Entry',
        path: 'stockentries',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Store', field: 'storeId', type: 'lookup', schema: { module: 'store' }, sorting: true, searching: true },
            { text: 'Item', field: 'itemId', type: 'lookup', schema: { module: 'itemMaster' }, sorting: true, searching: true },
            { text: 'Batch No', field: 'batchNo', type: 'text', sorting: true, searching: true },
            { text: 'Expiry', field: 'expiry', type: 'date', sorting: true, searching: true },
            { text: 'Qty Available', field: 'qtyAvailable', type: 'text', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewStockEntry = () => {
    const schema = {
        module: 'stockEntry',
        title: 'Stock Entry',
        path: 'stockentries',
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
                        text: 'Store', field: 'storeId', type: 'lookup-link', width: 6,
                        schema: { module: 'store', path: 'stores' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup-link', width: 6,
                        schema: { module: 'itemMaster', path: 'itemmasters' }
                    },
                    { text: 'Batch No', field: 'batchNo', type: 'label', width: 6 },
                    { text: 'Expiry', field: 'expiry', type: 'label', width: 6 },
                    { text: 'Qty Available', field: 'qtyAvailable', type: 'label', width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditStockEntry = () => {
    const schema = {
        module: 'stockEntry',
        title: 'Stock Entry',
        path: 'stockentries',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Store', field: 'storeId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'store' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'itemMaster' }
                    },
                    { text: 'Batch No', field: 'batchNo', fieldIcon: 'barcode', placeholder: 'Batch No here...', type: 'text', required: false, width: 6 },
                    { text: 'Expiry', field: 'expiry', fieldIcon: 'calendar', placeholder: 'Expiry here...', type: 'date', required: false, width: 6 },
                    { text: 'Qty Available', field: 'qtyAvailable', fieldIcon: 'hashtag', placeholder: 'Quantity Available here...', type: 'number', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddStockEntry = () => {
    const schema = {
        module: 'stockEntry',
        title: 'Stock Entry',
        path: 'stockentries',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Store', field: 'storeId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'store' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'itemMaster' }
                    },
                    { text: 'Batch No', field: 'batchNo', fieldIcon: 'barcode', placeholder: 'Batch No here...', type: 'text', required: false, width: 6 },
                    { text: 'Expiry', field: 'expiry', fieldIcon: 'calendar', placeholder: 'Expiry here...', type: 'date', required: false, width: 6 },
                    { text: 'Qty Available', field: 'qtyAvailable', fieldIcon: 'hashtag', placeholder: 'Quantity Available here...', type: 'number', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

