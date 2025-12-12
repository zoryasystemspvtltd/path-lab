import { useSelector } from "react-redux";
import { Card, Alert } from "react-bootstrap";
import { ListEnterprise } from "./schema/Enterprises";

const Dashboard = () => {
    const loggedInUser = useSelector((state) => state.api.loggedInUser);

    // Check if user has Enterprise role
    const isEnterpriseRole = () => {
        if (!loggedInUser?.roles) return false;
        
        // Check if roles array contains "Enterprise" role
        // Roles can be array of strings (role names) or array of objects with name property
        const roles = loggedInUser.roles;
        return roles.some(role => {
            const roleName = typeof role === 'string' ? role : role?.name || role?.roleName;
            return roleName && roleName.toLowerCase().includes('enterprise');
        });
    };

    return (
        <div className="container-fluid">
            <div className="row">
                <div className="col-12">
                    <h1 className="mb-4">Laboratory Management System</h1>
                </div>
            </div>

            {loggedInUser && isEnterpriseRole() ? (
                <div className="row">
                    <div className="col-12">
                        {/* <Card.Header>
                            <h4 className="mb-0">
                            <i className="fa fa-building me-2"></i>
                                Lab Test Centers
                            </h4>
                        </Card.Header> */}
                        <ListEnterprise />
                    </div>
                </div>
            ) : loggedInUser ? (
                <div className="row">
                    <div className="col-12">
                        <Card>
                            <Card.Body>
                                <Alert variant="warning">
                                    <i className="fa fa-exclamation-triangle me-2"></i>
                                    You do not have permission to view enterprise details. Please contact your administrator.
                                </Alert>
                            </Card.Body>
                        </Card>
                    </div>
                </div>
            ) : (
                <div className="row">
                    <div className="col-12">
                        <Card>
                            <Card.Body>
                                <Alert variant="info">
                                    Please log in to access your dashboard.
                                </Alert>
                            </Card.Body>
                        </Card>
                    </div>
                </div>
            )}
        </div>
    );
}

export default Dashboard;
