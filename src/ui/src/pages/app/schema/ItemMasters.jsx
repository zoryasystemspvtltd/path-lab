import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListItemMaster = () => {

    const schema = {
        module: 'itemMaster',
        title: 'Item Master',
        path: 'itemmasters',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Name', field: 'name', type: 'link', sorting: true, searching: true },
            { text: 'Alias', field: 'code', type: 'text', sorting: true, searching: true },
            { text: 'Type', field: 'type', type: 'text', sorting: true, searching: true },
            { text: 'category', field: 'categoryId', type: 'lookup', schema: { module: 'category' }, sorting: true, searching: true },
            { text: 'unitOfMeasure', field: 'unitOfMeasureId', type: 'lookup', schema: { module: 'unitOfMeasure' }, sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewItemMaster = () => {
    const schema = {
        module: 'itemMaster',
        title: 'Item Master',
        path: 'itemmasters',
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
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', type: 'label', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'label', required: true, width: 6 },                   
                    {
                        text: 'Type', field: 'typeId', type: 'lookup-enum', required: true, width: 6,
                        schema: { module: 'type', path: 'types' }
                    },
                    {
                        text: 'Category', field: 'categoryId', type: 'lookup-link', required: true, width: 6,
                        schema: { module: 'category', path: 'categorys' }
                    },
                    {
                        text: 'UnitOfMeasure', field: 'unitOfMeasureId', type: 'lookup-link', required: true, width: 6,
                        schema: { module: 'unitOfMeasure', path: 'unitOfMeasures' }
                    }
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditItemMaster = () => {
    const schema = {
        module: 'itemMaster',
        title: 'Item Master',
        path: 'itemmasters',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                    {
                        text: 'Type', field: 'typeId', type: 'lookup-enum', required: true, width: 6,
                        schema: { module: 'type', path: 'types' }
                    },
                    {
                        text: 'Category', field: 'categoryId', type: 'lookup-link', required: true, width: 6,
                        schema: { module: 'category', path: 'categorys' }
                    },
                    {
                        text: 'UnitOfMeasure', field: 'unitOfMeasureId', type: 'lookup-link', required: true, width: 6,
                        schema: { module: 'unitOfMeasure', path: 'unitOfMeasures' }
                    }
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddItemMaster = () => {
    const schema = {
        module: 'itemMaster',
        title: 'Item Master',
        path: 'itemmasters',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                    {
                        text: 'Type', field: 'typeId', type: 'lookup-enum', required: true, width: 6,
                        schema: { module: 'itemType', path: 'itemTypes' }
                    },
                    {
                        text: 'Category', field: 'categoryId', type: 'lookup-link', required: true, width: 6,
                        schema: { module: 'category', path: 'categorys' }
                    },
                    {
                        text: 'UnitOfMeasure', field: 'unitOfMeasureId', type: 'lookup-link', required: true, width: 6,
                        schema: { module: 'unitOfMeasure', path: 'unitOfMeasures' }
                    }
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}