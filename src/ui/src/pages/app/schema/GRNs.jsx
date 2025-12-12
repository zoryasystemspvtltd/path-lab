import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListGRN = () => {

    const schema = {
        module: 'grn',
        title: 'GRN',
        path: 'grns',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'GRN Number', field: 'id', type: 'link', sorting: true, searching: true },
            { text: 'Business Unit', field: 'businessUnitId', type: 'lookup', schema: { module: 'businessUnit' }, sorting: true, searching: true },
            { text: 'Purchase Order', field: 'poId', type: 'lookup', schema: { module: 'purchaseOrder' }, sorting: true, searching: true },
            { text: 'Date', field: 'date', type: 'date', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewGRN = () => {
    const schema = {
        module: 'grn',
        title: 'GRN',
        path: 'grns',
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
                    { text: 'GRN Number', field: 'id', fieldIcon: 'file-invoice', type: 'label', width: 6 },
                    {
                        text: 'Business Unit', field: 'businessUnitId', type: 'lookup-link', width: 6,
                        schema: { module: 'businessUnit', path: 'businessunits' }
                    },
                    {
                        text: 'Purchase Order', field: 'poId', type: 'lookup-link', width: 6,
                        schema: { module: 'purchaseOrder', path: 'purchaseorders' }
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
                            module: 'grnItem',
                            relationKey: "grnId",
                            title: 'GRN Items',
                            path: 'grnitems',
                            paging: true,
                            searching: true,
                            editing: false,
                            adding: false,
                            fields: [
                                { text: 'Item', field: 'itemId', type: 'lookup', schema: { module: 'itemMaster' }, sorting: true, searching: true, },
                                { text: 'Batch No', field: 'batchNo', type: 'text', sorting: false, searching: false },
                                { text: 'Expiry', field: 'expiry', type: 'date', sorting: false, searching: false },
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

export const EditGRN = () => {
    const schema = {
        module: 'grn',
        title: 'GRN',
        path: 'grns',
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
                        text: 'Purchase Order', field: 'poId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'purchaseOrder' }
                    },
                    { text: 'Date', field: 'date', fieldIcon: 'calendar', placeholder: 'Date here...', type: 'date', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddGRN = () => {
    const schema = {
        module: 'grn',
        title: 'GRN',
        path: 'grns',
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
                        text: 'Purchase Order', field: 'poId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'purchaseOrder' }
                    },
                    { text: 'Date', field: 'date', fieldIcon: 'calendar', placeholder: 'Date here...', type: 'date', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

