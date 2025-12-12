import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListTestParameter = () => {

    const schema = {
        module: 'testParameter',
        title: 'Test Parameter',
        path: 'testparameters',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Name', field: 'name', type: 'link', sorting: true, searching: true },
            { text: 'Test', field: 'testId', type: 'lookup', schema: { module: 'testMaster' }, sorting: true, searching: true },
            { text: 'Normal Range', field: 'normalRange', type: 'text', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewTestParameter = () => {
    const schema = {
        module: 'testParameter',
        title: 'Test Parameter',
        path: 'testparameters',
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
                    { text: 'Name', field: 'name', fieldIcon: 'list', type: 'label', width: 6 },
                    {
                        text: 'Test', field: 'testId', type: 'lookup-link', width: 6,
                        schema: { module: 'testMaster', path: 'testmasters' }
                    },
                    { text: 'Normal Range', field: 'normalRange', type: 'label', width: 12 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditTestParameter = () => {
    const schema = {
        module: 'testParameter',
        title: 'Test Parameter',
        path: 'testparameters',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'list', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    {
                        text: 'Test', field: 'testId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'testMaster' }
                    },
                    { text: 'Normal Range', field: 'normalRange', placeholder: 'Normal Range here...', type: 'text', required: false, width: 12 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddTestParameter = () => {
    const schema = {
        module: 'testParameter',
        title: 'Test Parameter',
        path: 'testparameters',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'list', placeholder: 'Name here...', type: 'text', required: true, width: 6 },
                    {
                        text: 'Test', field: 'testId', type: 'lookup', required: true, width: 6,
                        schema: { module: 'testMaster' }
                    },
                    { text: 'Normal Range', field: 'normalRange', placeholder: 'Normal Range here...', type: 'text', required: false, width: 12 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

