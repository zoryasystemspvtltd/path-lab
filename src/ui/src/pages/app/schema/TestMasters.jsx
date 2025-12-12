import IUIList from "../../common/IUIList";
import IUIPage from "../../common/IUIPage"

export const ListTestMaster = () => {

    const schema = {
        module: 'testMaster',
        title: 'Test Master',
        path: 'testmasters',
        paging: true,
        searching: true,
        editing: true,
        adding: true,
        fields: [
            { text: 'Name', field: 'name', type: 'link', sorting: true, searching: true },
        ]
    }

    return (<IUIList schema={schema} />)
}

export const ViewTestMaster = () => {
    const schema = {
        module: 'testMaster',
        title: 'Test Master',
        path: 'testmasters',
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
                    { text: 'Name', field: 'name', fieldIcon: 'flask', type: 'label', width: 12 },
                ]
            },
            {
                type: "area", width: 12
                , fields: [
                    {
                        type: 'module-relation',
                        schema: {
                            module: 'testParameter',
                            relationKey: "testId",
                            title: 'Test Parameters',
                            path: 'testparameters',
                            paging: true,
                            searching: true,
                            editing: false,
                            adding: false,
                            fields: [
                                { text: 'Name', field: 'name', type: 'link', sorting: true, searching: true, },
                                { text: 'Normal Range', field: 'normalRange', type: 'text', sorting: false, searching: false },
                            ]
                        },
                    }
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const EditTestMaster = () => {
    const schema = {
        module: 'testMaster',
        title: 'Test Master',
        path: 'testmasters',
        back: false,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'flask', placeholder: 'Name here...', type: 'text', required: true, width: 12 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

export const AddTestMaster = () => {
    const schema = {
        module: 'testMaster',
        title: 'Test Master',
        path: 'testmasters',
        back: true,
        fields: [
            {
                type: "area", width: 12
                , fields: [
                    { text: 'Name', field: 'name', fieldIcon: 'flask', placeholder: 'Name here...', type: 'text', required: true, width: 12 },
                ]
            }
        ]
    }

    return (<IUIPage schema={schema} />)
}

