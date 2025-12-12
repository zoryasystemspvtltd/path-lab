import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListStockAdjustment = () => {

    const schema = {
        module: 'stockAdjustment',
        title: 'Stock Adjustment',
        path: 'stockadjustments',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Store', field: 'storeId', type: 'lookup', schema: { module: 'store' }, sorting: true, searching: true },
            { text: 'Item', field: 'itemId', type: 'lookup', schema: { module: 'itemMaster' }, sorting: true, searching: true },
            { text: 'Reason', field: 'reason', type: 'text', sorting: true, searching: true },
            { text: 'Qty Adjusted', field: 'qtyAdjusted', type: 'text', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewStockAdjustment = () => {
    const schema = {
        module: 'stockAdjustment',
        title: 'Stock Adjustment',
        path: 'stockadjustments',
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
                    { text: 'Reason', field: 'reason', type: 'label', width: 12 },
                    { text: 'Qty Adjusted', field: 'qtyAdjusted', type: 'label', width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditStockAdjustment = () => {
    const schema = {
        module: 'stockAdjustment',
        title: 'Stock Adjustment',
        path: 'stockadjustments',
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
                    { text: 'Reason', field: 'reason', fieldIcon: 'comment', placeholder: 'Reason here...', type: 'textarea', required: false, width: 12 },
                    { text: 'Qty Adjusted', field: 'qtyAdjusted', fieldIcon: 'hashtag', placeholder: 'Quantity Adjusted here...', type: 'number', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddStockAdjustment = () => {
    const schema = {
        module: 'stockAdjustment',
        title: 'Stock Adjustment',
        path: 'stockadjustments',
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
                    { text: 'Reason', field: 'reason', fieldIcon: 'comment', placeholder: 'Reason here...', type: 'textarea', required: false, width: 12 },
                    { text: 'Qty Adjusted', field: 'qtyAdjusted', fieldIcon: 'hashtag', placeholder: 'Quantity Adjusted here...', type: 'number', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

