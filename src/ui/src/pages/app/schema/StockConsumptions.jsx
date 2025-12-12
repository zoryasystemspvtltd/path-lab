import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListStockConsumption = () => {

    const schema = {
        module: 'stockConsumption',
        title: 'Stock Consumption',
        path: 'stockconsumptions',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Test', field: 'testId', type: 'lookup', schema: { module: 'testMaster' }, sorting: true, searching: true },
            { text: 'Item', field: 'itemId', type: 'lookup', schema: { module: 'itemMaster' }, sorting: true, searching: true },
            { text: 'Quantity Used', field: 'quantityUsed', type: 'text', sorting: true, searching: true },
            { text: 'Date', field: 'date', type: 'date', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewStockConsumption = () => {
    const schema = {
        module: 'stockConsumption',
        title: 'Stock Consumption',
        path: 'stockconsumptions',
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
                        text: 'Test', field: 'testId', type: 'lookup-link', width: 6,
                        schema: { module: 'testMaster', path: 'testmasters' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup-link', width: 6,
                        schema: { module: 'itemMaster', path: 'itemmasters' }
                    },
                    { text: 'Quantity Used', field: 'quantityUsed', type: 'label', width: 6 },
                    { text: 'Date', field: 'date', type: 'label', width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditStockConsumption = () => {
    const schema = {
        module: 'stockConsumption',
        title: 'Stock Consumption',
        path: 'stockconsumptions',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Test', field: 'testId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'testMaster' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'itemMaster' }
                    },
                    { text: 'Quantity Used', field: 'quantityUsed', fieldIcon: 'hashtag', placeholder: 'Quantity Used here...', type: 'number', required: true, width: 6 },
                    { text: 'Date', field: 'date', fieldIcon: 'calendar', placeholder: 'Date here...', type: 'date', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddStockConsumption = () => {
    const schema = {
        module: 'stockConsumption',
        title: 'Stock Consumption',
        path: 'stockconsumptions',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    {
                        text: 'Test', field: 'testId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'testMaster' }
                    },
                    {
                        text: 'Item', field: 'itemId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'itemMaster' }
                    },
                    { text: 'Quantity Used', field: 'quantityUsed', fieldIcon: 'hashtag', placeholder: 'Quantity Used here...', type: 'number', required: true, width: 6 },
                    { text: 'Date', field: 'date', fieldIcon: 'calendar', placeholder: 'Date here...', type: 'date', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

