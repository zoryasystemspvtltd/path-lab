import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListVendor = () => {

    const schema = {
        module: 'vendor',
        title: 'Vendor',
        path: 'vendors',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Name', field: 'name', type: 'link', sorting: true, searching: true },
            { text: 'Alias', field: 'code', type: 'text', sorting: true, searching: true },
            { text: 'Contact', field: 'contact', type: 'text', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewVendor = () => {
    const schema = {
        module: 'vendor',
        title: 'Vendor',
        path: 'vendors',
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
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                    { text: 'Contact', field: 'contact', type: 'text', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditVendor = () => {
    const schema = {
        module: 'vendor',
        title: 'Vendor',
        path: 'vendors',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                    { text: 'Contact', field: 'contact', type: 'text', required: true, width: 6 }
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddVendor = () => {
    const schema = {
        module: 'vendor',
        title: 'Vendor',
        path: 'vendors',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'object-group', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    { text: 'Alias', field: 'code', type: 'text', required: true, width: 6 },
                    { text: 'Contact', field: 'contact', type: 'text', required: true, width: 6 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}