import { RouterProvider, createBrowserRouter } from "react-router-dom";
import ForgotPassword from "../pages/ForgotPassword";
import Home from "../pages/Home";
import Login from "../pages/Login";
import Logout from "../pages/Logout";
import Refresh from "../pages/Refresh";
import ResetPassword from "../pages/ResetPassword";
import Signup from "../pages/Signup";

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
    ];

    // Define routes accessible only to authenticated users
    const routesForAuthenticatedOnly = [
        {
            path: "/",
            element: <ProtectedRoute />, // Wrap the component in ProtectedRoute
            children: [
                {
                    path: "",
                    element: <Home />,
                },
                {
                    path: "/home",
                    element: <Dashboard />,
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
