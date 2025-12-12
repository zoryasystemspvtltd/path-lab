import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListGRNItem = () => {

    const schema = {
        module: 'grnitem',
        title: 'GRN Item',
        path: 'grnitem',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'GRN', field: 'grnId', type: 'lookup', schema: { module: 'grn' }, sorting: true, searching: true },
            { text: 'Item', field: 'itemId', type: 'lookup', schema: { module: 'itemMaster' }, sorting: true, searching: true },
            { text: 'Batch No', field: 'batchNo', type: 'text', sorting: true, searching: true },
            { text: 'Expiry', field: 'expiry', type: 'date', sorting: true, searching: true },
            { text: 'Quantity', field: 'quantity', type: 'text', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewGRNItem = () => {
    const schema = {
        module: 'grnitem',
        title: 'GRN Item',
        path: 'grnitem',
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
                        text: 'GRN', field: 'grnId', type: 'lookup-link', width: 6,
                        schema: { module: 'grn', path: 'grns' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup-link', width: 6,
                        schema: { module: 'itemMaster', path: 'itemmasters' }
                    },
                    { text: 'Batch No', field: 'batchNo', type: 'label', width: 6 },
                    { text: 'Expiry', field: 'expiry', type: 'label', width: 6 },
                    { text: 'Quantity', field: 'quantity', type: 'label', width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditGRNItem = () => {
    const schema = {
        module: 'grnitem',
        title: 'GRN Item',
        path: 'grnitem',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'GRN', field: 'grnId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'grn' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'itemMaster' }
                    },
                    { text: 'Batch No', field: 'batchNo', fieldIcon: 'barcode', placeholder: 'Batch No here...', type: 'text', required: false, width: 6 },
                    { text: 'Expiry', field: 'expiry', fieldIcon: 'calendar', placeholder: 'Expiry here...', type: 'date', required: false, width: 6 },
                    { text: 'Quantity', field: 'quantity', fieldIcon: 'hashtag', placeholder: 'Quantity here...', type: 'number', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddGRNItem = () => {
    const schema = {
        module: 'grnitem',
        title: 'GRN Item',
        path: 'grnitem',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'GRN', field: 'grnId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'grn' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'itemMaster' }
                    },
                    { text: 'Batch No', field: 'batchNo', fieldIcon: 'barcode', placeholder: 'Batch No here...', type: 'text', required: false, width: 6 },
                    { text: 'Expiry', field: 'expiry', fieldIcon: 'calendar', placeholder: 'Expiry here...', type: 'date', required: false, width: 6 },
                    { text: 'Quantity', field: 'quantity', fieldIcon: 'hashtag', placeholder: 'Quantity here...', type: 'number', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}
