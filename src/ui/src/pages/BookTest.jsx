import { useState } from "react";
import { Col, Container, Row, Card, Button } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import logo from "../assets/images/zorya_logo.png";

const BookTest = () => {
    const navigate = useNavigate();
    
    // Sample test packages data
    const testPackages = [
        {
            id: 1,
            name: "Complete Health Package",
            description: "Comprehensive health screening including blood tests, liver function, kidney function, and lipid profile",
            price: "₹2,500",
            tests: ["Complete Blood Count", "Liver Function Test", "Kidney Function Test", "Lipid Profile", "Blood Sugar"],
            icon: "fa-flask"
        },
        {
            id: 2,
            name: "Diabetes Care Package",
            description: "Essential tests for diabetes monitoring and management",
            price: "₹1,200",
            tests: ["HbA1c", "Fasting Blood Sugar", "Post Prandial Blood Sugar", "Lipid Profile"],
            icon: "fa-heartbeat"
        },
        {
            id: 3,
            name: "Cardiac Care Package",
            description: "Complete cardiac health assessment package",
            price: "₹3,500",
            tests: ["ECG", "Echocardiography", "Lipid Profile", "Cardiac Enzymes", "Chest X-Ray"],
            icon: "fa-heart"
        },
        {
            id: 4,
            name: "Women's Health Package",
            description: "Comprehensive women's health screening package",
            price: "₹3,000",
            tests: ["Pap Smear", "Mammography", "Bone Density", "Hormone Profile", "Thyroid Function"],
            icon: "fa-female"
        },
        {
            id: 5,
            name: "Thyroid Profile Package",
            description: "Complete thyroid function assessment",
            price: "₹800",
            tests: ["TSH", "T3", "T4", "Free T3", "Free T4", "Anti-TPO"],
            icon: "fa-stethoscope"
        },
        {
            id: 6,
            name: "Liver Function Package",
            description: "Comprehensive liver health screening",
            price: "₹1,500",
            tests: ["ALT", "AST", "ALP", "Bilirubin", "Albumin", "Prothrombin Time"],
            icon: "fa-liver"
        }
    ];

    const handleViewTests = (packageId) => {
        navigate(`/book-test/${packageId}/tests`);
    };

    return (
        <div className="app-container app-theme-white body-tabs-shadow min-vh-100 d-flex flex-column bg-light">
            <header className="d-flex align-items-center justify-content-between py-4 px-5 border-bottom bg-white">
                <div className="d-flex align-items-center">
                    <img src={logo} alt="PathLab logo" height="56" className="mr-3" />
                    <div>
                        <p className="text-uppercase text-primary mb-1 font-weight-bold">PathLab Suite</p>
                        <p className="text-muted mb-0">Book Your Laboratory Tests</p>
                    </div>
                </div>
                <div className="d-flex gap-3">
                    <Link to="/home" className="btn btn-outline-secondary btn-lg px-4">
                        Home
                    </Link>
                    <Link to="/login" className="btn btn-primary btn-lg btn-shadow btn-hover-shine px-4">
                        Login
                    </Link>
                </div>
            </header>

            <main className="flex-grow-1 py-5">
                <Container>
                    <div className="text-center mb-5">
                        <h1 className="display-4 font-weight-bold mb-3">Choose Your Test Package</h1>
                        <p className="lead text-muted">
                            Select from our comprehensive range of health checkup packages
                        </p>
                    </div>

                    <Row className="gy-4">
                        {testPackages.map((pkg) => (
                            <Col key={pkg.id} md={6} lg={4}>
                                <Card className="h-100 shadow-sm border-0">
                                    <Card.Body className="d-flex flex-column">
                                        <div className="text-center mb-3">
                                            <i className={`fa ${pkg.icon} fa-3x text-primary mb-3`}></i>
                                            <Card.Title className="h4 font-weight-bold">{pkg.name}</Card.Title>
                                        </div>
                                        <Card.Text className="text-muted mb-3 flex-grow-1">
                                            {pkg.description}
                                        </Card.Text>
                                        <div className="mb-3">
                                            <strong className="text-primary h5">{pkg.price}</strong>
                                        </div>
                                        <div className="mb-3">
                                            <small className="text-muted d-block mb-2">
                                                <strong>Includes:</strong> {pkg.tests.length} tests
                                            </small>
                                            <ul className="list-unstyled small text-muted">
                                                {pkg.tests.slice(0, 3).map((test, idx) => (
                                                    <li key={idx}>
                                                        <i className="fa fa-check text-success mr-2"></i>
                                                        {test}
                                                    </li>
                                                ))}
                                                {pkg.tests.length > 3 && (
                                                    <li className="text-primary">
                                                        +{pkg.tests.length - 3} more tests
                                                    </li>
                                                )}
                                            </ul>
                                        </div>
                                        <Button
                                            variant="primary"
                                            className="btn-wide btn-pill btn-shadow btn-hover-shine mt-auto"
                                            onClick={() => handleViewTests(pkg.id)}
                                        >
                                            View All Tests
                                        </Button>
                                    </Card.Body>
                                </Card>
                            </Col>
                        ))}
                    </Row>
                </Container>
            </main>

            <footer className="py-4 px-5 border-top bg-white">
                <div className="d-flex flex-column flex-md-row justify-content-between align-items-center">
                    <p className="mb-0 text-muted">© {new Date().getFullYear()} Zorya Digital Labs. All rights reserved.</p>
                    <div className="d-flex gap-4 mt-3 mt-md-0">
                        <Link to="/service" className="text-secondary">Services</Link>
                        <Link to="/about-us" className="text-secondary">About</Link>
                        <a href="mailto:support@zoryadigital.com" className="text-secondary">Support</a>
                    </div>
                </div>
            </footer>
        </div>
    );
};

export default BookTest;


