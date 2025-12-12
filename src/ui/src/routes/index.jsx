import { Navigate, RouterProvider, createBrowserRouter } from "react-router-dom";
import ForgotPassword from "../pages/ForgotPassword";
import Home from "../pages/Home";
import Login from "../pages/Login";
import Logout from "../pages/Logout";
import Refresh from "../pages/Refresh";
import ResetPassword from "../pages/ResetPassword";
import Signup from "../pages/Signup";
import BookTest from "../pages/BookTest";
import IndividualTests from "../pages/IndividualTests";

import { AddRole, EditRole, ListRole, ViewRole } from "../pages/app/schema/Roles";
import { AddUser, EditUser, ListUser, ResetPasswordUser, ViewUser } from "../pages/app/schema/Users";

import ChangePassword from "../pages/app/ChangePassword";
import ChangePasswordSuccess from "../pages/app/ChangePasswordSuccess";
import Dashboard from "../pages/app/Dashboard";
import { EditProfile, ViewProfile } from "../pages/app/Profile";

import { AddDepartment, EditDepartment, ListDepartment, ViewDepartment } from "../pages/app/schema/Departments";

import { useAuth } from "../provider/authProvider";
import { ProtectedRoute } from "./ProtectedRoute";
import { AddEnterprise, EditEnterprise, ListEnterprise, ViewEnterprise } from "../pages/app/schema/Enterprises";
import { AddBusinessUnit, EditBusinessUnit, ViewBusinessUnit, ListBusinessUnit } from "../pages/app/schema/BusinessUnits";
import { AddItemMaster, EditItemMaster, ViewItemMaster, ListItemMaster } from "../pages/app/schema/ItemMasters";
import { AddCategory, EditCategory, ViewCategory, ListCategory } from "../pages/app/schema/Categorys";
import { AddVendor, EditVendor, ViewVendor, ListVendor } from "../pages/app/schema/Vendors";
import { AddUnitOfMeasure, EditUnitOfMeasure, ViewUnitOfMeasure, ListUnitOfMeasure } from "../pages/app/schema/UnitOfMeasures";
import { AddStore, EditStore, ViewStore, ListStore } from "../pages/app/schema/Stores";
import { AddTestMaster, EditTestMaster, ViewTestMaster, ListTestMaster } from "../pages/app/schema/TestMasters";
import { AddTestParameter, EditTestParameter, ViewTestParameter, ListTestParameter } from "../pages/app/schema/TestParameters";
import { AddPurchaseOrder, EditPurchaseOrder, ViewPurchaseOrder, ListPurchaseOrder } from "../pages/app/schema/PurchaseOrders";
import { AddPOItem, EditPOItem, ViewPOItem, ListPOItem } from "../pages/app/schema/POItems";
import { AddIndent, EditIndent, ViewIndent, ListIndent } from "../pages/app/schema/Indents";
import { AddIndentItem, EditIndentItem, ViewIndentItem, ListIndentItem } from "../pages/app/schema/IndentItems";
import { AddGRN, EditGRN, ViewGRN, ListGRN } from "../pages/app/schema/GRNs";
import { AddGRNItem, EditGRNItem, ViewGRNItem, ListGRNItem } from "../pages/app/schema/GRNItems";
import { AddStockEntry, EditStockEntry, ViewStockEntry, ListStockEntry } from "../pages/app/schema/StockEntries";
import { AddReagentMapping, EditReagentMapping, ViewReagentMapping, ListReagentMapping } from "../pages/app/schema/ReagentMappings";
import { AddStockAdjustment, EditStockAdjustment, ViewStockAdjustment, ListStockAdjustment } from "../pages/app/schema/StockAdjustments";
import { AddStockConsumption, EditStockConsumption, ViewStockConsumption, ListStockConsumption } from "../pages/app/schema/StockConsumptions";

const Routes = () => {
    const { token } = useAuth();

    // Define public routes accessible to all users
    const routesForPublic = [
        {
            path: "/service",
            element: <div>Service Page</div>,
        },
        {
            path: "/about-us",
            element: <div>About Us</div>,
        },
        {
            path: "/book-test",
            element: <BookTest />,
        },
        {
            path: "/book-test/:packageId/tests",
            element: <IndividualTests />,
        },
    ];

    // Define routes accessible only to authenticated users
    const routesForAuthenticatedOnly = [
        {
            path: "/",
            element: <ProtectedRoute />, // Wrap the component in ProtectedRoute
            children: [
                {
                    path: "",
                    element: <Dashboard />,
                },
                {
                    path: "/dashboard",
                    element: <Dashboard />,
                },
                {
                    path: "/home",
                    element: <Navigate to="/dashboard" replace />,
                },
                {
                    path: "/change-password",
                    element: <ChangePassword />,
                },
                {
                    path: "/change-password-success",
                    element: <ChangePasswordSuccess />
                },
                {
                    path: "/view-profile",
                    element: <ViewProfile />
                },
                {
                    path: "/edit-profile",
                    element: <EditProfile />
                },
                {
                    path: "/logout",
                    element: <Logout />,
                },
                {
                    path: "/roles",
                    element: <ListRole />
                },
                {
                    path: "/roles/:id",
                    element: <ViewRole />
                },
                {
                    path: "/roles/add",
                    element: <AddRole />
                },
                {
                    path: "/roles/:id/edit",
                    element: <EditRole />
                },
                {
                    path: "/users",
                    element: <ListUser />
                },
                {
                    path: "/users/:id",
                    element: <ViewUser />
                },
                {
                    path: "/users/:id/edit",
                    element: <EditUser />
                },
                {
                    path: "/users/add",
                    element: <AddUser />
                },
                {
                    path: "/users/reset-password",
                    element: <ResetPasswordUser />
                },
                {
                    path: "/departments",
                    element: <ListDepartment />
                },
                {
                    path: "/departments/:id",
                    element: <ViewDepartment />
                },
                {
                    path: "/departments/:id/edit",
                    element: <EditDepartment />
                },
                {
                    path: "/departments/add",
                    element: <AddDepartment />
                },

                {
                    path: "/enterprises",
                    element: <ListEnterprise />
                },
                {
                    path: "/enterprises/:id",
                    element: <ViewEnterprise />
                },
                {
                    path: "/enterprises/:id/edit",
                    element: <EditEnterprise />
                },
                {
                    path: "/enterprises/add",
                    element: <AddEnterprise />
                },
                {
                    path: "/businessunits",
                    element: <ListBusinessUnit />
                },
                {
                    path: "/businessunits/:id",
                    element: <ViewBusinessUnit />
                },
                {
                    path: "/businessunits/:id/edit",
                    element: <EditBusinessUnit />
                },
                {
                    path: "/businessunits/add",
                    element: <AddBusinessUnit />
                },
                {
                    path: "/vendors",
                    element: <ListVendor />
                },
                {
                    path: "/vendors/:id",
                    element: <ViewVendor />
                },
                {
                    path: "/vendors/:id/edit",
                    element: <EditVendor />
                },
                {
                    path: "/vendors/add",
                    element: <AddVendor />
                },
                {
                    path: "/unitOfMeasures",
                    element: <ListUnitOfMeasure />
                },
                {
                    path: "/unitOfMeasures/:id",
                    element: <ViewUnitOfMeasure />
                },
                {
                    path: "/unitOfMeasures/:id/edit",
                    element: <EditUnitOfMeasure />
                },
                {
                    path: "/unitOfMeasures/add",
                    element: <AddUnitOfMeasure />
                },
                {
                    path: "/itemmasters",
                    element: <ListItemMaster />
                },
                {
                    path: "/itemmasters/:id",
                    element: <ViewItemMaster />
                },
                {
                    path: "/itemmasters/:id/edit",
                    element: <EditItemMaster />
                },
                {
                    path: "/itemmasters/add",
                    element: <AddItemMaster />
                },
                {
                    path: "/categorys",
                    element: <ListCategory />
                },
                {
                    path: "/categorys/:id",
                    element: <ViewCategory />
                },
                {
                    path: "/categorys/:id/edit",
                    element: <EditCategory />
                },
                {
                    path: "/categorys/add",
                    element: <AddCategory />
                },
                {
                    path: "/stores",
                    element: <ListStore />
                },
                {
                    path: "/stores/:id",
                    element: <ViewStore />
                },
                {
                    path: "/stores/:id/edit",
                    element: <EditStore />
                },
                {
                    path: "/stores/add",
                    element: <AddStore />
                },
                {
                    path: "/testmasters",
                    element: <ListTestMaster />
                },
                {
                    path: "/testmasters/:id",
                    element: <ViewTestMaster />
                },
                {
                    path: "/testmasters/:id/edit",
                    element: <EditTestMaster />
                },
                {
                    path: "/testmasters/add",
                    element: <AddTestMaster />
                },
                {
                    path: "/testparameters",
                    element: <ListTestParameter />
                },
                {
                    path: "/testparameters/:id",
                    element: <ViewTestParameter />
                },
                {
                    path: "/testparameters/:id/edit",
                    element: <EditTestParameter />
                },
                {
                    path: "/testparameters/add",
                    element: <AddTestParameter />
                },
                {
                    path: "/purchaseorders",
                    element: <ListPurchaseOrder />
                },
                {
                    path: "/purchaseorders/:id",
                    element: <ViewPurchaseOrder />
                },
                {
                    path: "/purchaseorders/:id/edit",
                    element: <EditPurchaseOrder />
                },
                {
                    path: "/purchaseorders/add",
                    element: <AddPurchaseOrder />
                },
                {
                    path: "/poitems",
                    element: <ListPOItem />
                },
                {
                    path: "/poitems/:id",
                    element: <ViewPOItem />
                },
                {
                    path: "/poitems/:id/edit",
                    element: <EditPOItem />
                },
                {
                    path: "/poitems/add",
                    element: <AddPOItem />
                },
                {
                    path: "/indents",
                    element: <ListIndent />
                },
                {
                    path: "/indents/:id",
                    element: <ViewIndent />
                },
                {
                    path: "/indents/:id/edit",
                    element: <EditIndent />
                },
                {
                    path: "/indents/add",
                    element: <AddIndent />
                },
                {
                    path: "/indentitems",
                    element: <ListIndentItem />
                },
                {
                    path: "/indentitems/:id",
                    element: <ViewIndentItem />
                },
                {
                    path: "/indentitems/:id/edit",
                    element: <EditIndentItem />
                },
                {
                    path: "/indentitems/add",
                    element: <AddIndentItem />
                },
                {
                    path: "/grns",
                    element: <ListGRN />
                },
                {
                    path: "/grns/:id",
                    element: <ViewGRN />
                },
                {
                    path: "/grns/:id/edit",
                    element: <EditGRN />
                },
                {
                    path: "/grns/add",
                    element: <AddGRN />
                },
                {
                    path: "/grnitems",
                    element: <ListGRNItem />
                },
                {
                    path: "/grnitems/:id",
                    element: <ViewGRNItem />
                },
                {
                    path: "/grnitems/:id/edit",
                    element: <EditGRNItem />
                },
                {
                    path: "/grnitems/add",
                    element: <AddGRNItem />
                },
                {
                    path: "/stockentries",
                    element: <ListStockEntry />
                },
                {
                    path: "/stockentries/:id",
                    element: <ViewStockEntry />
                },
                {
                    path: "/stockentries/:id/edit",
                    element: <EditStockEntry />
                },
                {
                    path: "/stockentries/add",
                    element: <AddStockEntry />
                },
                {
                    path: "/reagentmappings",
                    element: <ListReagentMapping />
                },
                {
                    path: "/reagentmappings/:id",
                    element: <ViewReagentMapping />
                },
                {
                    path: "/reagentmappings/:id/edit",
                    element: <EditReagentMapping />
                },
                {
                    path: "/reagentmappings/add",
                    element: <AddReagentMapping />
                },
                {
                    path: "/stockadjustments",
                    element: <ListStockAdjustment />
                },
                {
                    path: "/stockadjustments/:id",
                    element: <ViewStockAdjustment />
                },
                {
                    path: "/stockadjustments/:id/edit",
                    element: <EditStockAdjustment />
                },
                {
                    path: "/stockadjustments/add",
                    element: <AddStockAdjustment />
                },
                {
                    path: "/stockconsumptions",
                    element: <ListStockConsumption />
                },
                {
                    path: "/stockconsumptions/:id",
                    element: <ViewStockConsumption />
                },
                {
                    path: "/stockconsumptions/:id/edit",
                    element: <EditStockConsumption />
                },
                {
                    path: "/stockconsumptions/add",
                    element: <AddStockConsumption />
                },
            ],
        },
    ];

    // Define routes accessible only to non-authenticated users
    const routesForNotAuthenticatedOnly = [
        {
            path: "/",
            element: <Home />,
        },
        {
            path: "/home",
            element: <Home />,
        },
        {
            path: "/login",
            element: <Login />,
        },
        {
            path: "/refresh",
            element: <Refresh />
        },
        {
            path: "/signup",
            element: <Signup />
        },
        {
            path: "/reset-password",
            element: <ResetPassword />
        },
        {
            path: "/forgot-password",
            element: <ForgotPassword />
        }
    ];

    // Combine and conditionally include routes based on authentication status
    const router = createBrowserRouter([
        ...routesForPublic,
        ...(!token ? routesForNotAuthenticatedOnly : []),
        ...routesForAuthenticatedOnly,
    ]);

    // Provide the router configuration using RouterProvider
    return <RouterProvider router={router} />;
};

export default Routes;
