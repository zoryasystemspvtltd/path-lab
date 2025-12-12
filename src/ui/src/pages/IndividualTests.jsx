import { useState, useEffect } from "react";
import { Col, Container, Row, Card, Button, Table, Badge } from "react-bootstrap";
import { Link, useNavigate, useParams } from "react-router-dom";
import logo from "../assets/images/zorya_logo.png";

const IndividualTests = () => {
    const navigate = useNavigate();
    const { packageId } = useParams();
    
    // Sample test packages data (same as BookTest)
    const testPackages = {
        1: {
            name: "Complete Health Package",
            description: "Comprehensive health screening including blood tests, liver function, kidney function, and lipid profile",
            price: "₹2,500",
            tests: [
                { id: 1, name: "Complete Blood Count (CBC)", price: "₹500", description: "Measures red blood cells, white blood cells, and platelets" },
                { id: 2, name: "Liver Function Test (LFT)", price: "₹600", description: "Assesses liver health and function" },
                { id: 3, name: "Kidney Function Test (KFT)", price: "₹500", description: "Evaluates kidney health and function" },
                { id: 4, name: "Lipid Profile", price: "₹400", description: "Measures cholesterol and triglyceride levels" },
                { id: 5, name: "Blood Sugar (Fasting)", price: "₹200", description: "Measures fasting blood glucose levels" }
            ]
        },
        2: {
            name: "Diabetes Care Package",
            description: "Essential tests for diabetes monitoring and management",
            price: "₹1,200",
            tests: [
                { id: 6, name: "HbA1c", price: "₹500", description: "Average blood sugar over 2-3 months" },
                { id: 7, name: "Fasting Blood Sugar", price: "₹200", description: "Blood glucose after overnight fasting" },
                { id: 8, name: "Post Prandial Blood Sugar", price: "₹200", description: "Blood glucose 2 hours after meal" },
                { id: 9, name: "Lipid Profile", price: "₹400", description: "Cholesterol and triglyceride levels" }
            ]
        },
        3: {
            name: "Cardiac Care Package",
            description: "Complete cardiac health assessment package",
            price: "₹3,500",
            tests: [
                { id: 10, name: "ECG (Electrocardiogram)", price: "₹500", description: "Records electrical activity of the heart" },
                { id: 11, name: "Echocardiography", price: "₹2,000", description: "Ultrasound imaging of the heart" },
                { id: 12, name: "Lipid Profile", price: "₹400", description: "Cholesterol and triglyceride levels" },
                { id: 13, name: "Cardiac Enzymes", price: "₹500", description: "Measures heart muscle damage markers" },
                { id: 14, name: "Chest X-Ray", price: "₹300", description: "Imaging of chest and heart" }
            ]
        },
        4: {
            name: "Women's Health Package",
            description: "Comprehensive women's health screening package",
            price: "₹3,000",
            tests: [
                { id: 15, name: "Pap Smear", price: "₹800", description: "Cervical cancer screening" },
                { id: 16, name: "Mammography", price: "₹1,500", description: "Breast cancer screening" },
                { id: 17, name: "Bone Density Test", price: "₹1,000", description: "Osteoporosis screening" },
                { id: 18, name: "Hormone Profile", price: "₹1,200", description: "Female hormone levels assessment" },
                { id: 19, name: "Thyroid Function Test", price: "₹600", description: "Thyroid hormone levels" }
            ]
        },
        5: {
            name: "Thyroid Profile Package",
            description: "Complete thyroid function assessment",
            price: "₹800",
            tests: [
                { id: 20, name: "TSH (Thyroid Stimulating Hormone)", price: "₹300", description: "Primary thyroid function test" },
                { id: 21, name: "T3 (Triiodothyronine)", price: "₹200", description: "Active thyroid hormone" },
                { id: 22, name: "T4 (Thyroxine)", price: "₹200", description: "Main thyroid hormone" },
                { id: 23, name: "Free T3", price: "₹200", description: "Unbound T3 hormone" },
                { id: 24, name: "Free T4", price: "₹200", description: "Unbound T4 hormone" },
                { id: 25, name: "Anti-TPO", price: "₹300", description: "Thyroid antibody test" }
            ]
        },
        6: {
            name: "Liver Function Package",
            description: "Comprehensive liver health screening",
            price: "₹1,500",
            tests: [
                { id: 26, name: "ALT (Alanine Aminotransferase)", price: "₹200", description: "Liver enzyme test" },
                { id: 27, name: "AST (Aspartate Aminotransferase)", price: "₹200", description: "Liver enzyme test" },
                { id: 28, name: "ALP (Alkaline Phosphatase)", price: "₹200", description: "Liver and bone enzyme" },
                { id: 29, name: "Bilirubin (Total)", price: "₹200", description: "Bile pigment measurement" },
                { id: 30, name: "Albumin", price: "₹300", description: "Liver protein synthesis" },
                { id: 31, name: "Prothrombin Time", price: "₹400", description: "Blood clotting function" }
            ]
        }
    };

    const [selectedTests, setSelectedTests] = useState([]);
    const currentPackage = testPackages[packageId];

    useEffect(() => {
        if (!currentPackage) {
            navigate("/book-test");
        }
    }, [packageId, currentPackage, navigate]);

    if (!currentPackage) {
        return null;
    }

    const toggleTestSelection = (test) => {
        setSelectedTests(prev => {
            const exists = prev.find(t => t.id === test.id);
            if (exists) {
                return prev.filter(t => t.id !== test.id);
            } else {
                return [...prev, test];
            }
        });
    };

    const calculateTotal = () => {
        return selectedTests.reduce((sum, test) => {
            const price = parseInt(test.price.replace('₹', '').replace(',', ''));
            return sum + price;
        }, 0);
    };

    const handleBookNow = () => {
        // Navigate to login if not authenticated, or to booking confirmation
        navigate("/login", { state: { selectedTests, packageId } });
    };

    return (
        <div className="app-container app-theme-white body-tabs-shadow min-vh-100 d-flex flex-column bg-light">
            <header className="d-flex align-items-center justify-content-between py-4 px-5 border-bottom bg-white">
                <div className="d-flex align-items-center">
                    <img src={logo} alt="PathLab logo" height="56" className="mr-3" />
                    <div>
                        <p className="text-uppercase text-primary mb-1 font-weight-bold">PathLab Suite</p>
                        <p className="text-muted mb-0">Select Individual Tests</p>
                    </div>
                </div>
                <div className="d-flex gap-3">
                    <Link to="/book-test" className="btn btn-outline-secondary btn-lg px-4">
                        Back to Packages
                    </Link>
                    <Link to="/login" className="btn btn-primary btn-lg btn-shadow btn-hover-shine px-4">
                        Login
                    </Link>
                </div>
            </header>

            <main className="flex-grow-1 py-5">
                <Container>
                    <div className="mb-4">
                        <Link to="/book-test" className="text-secondary mb-2 d-inline-block">
                            <i className="fa fa-arrow-left mr-2"></i>Back to Packages
                        </Link>
                        <h1 className="display-5 font-weight-bold mb-2">{currentPackage.name}</h1>
                        <p className="lead text-muted">{currentPackage.description}</p>
                        <div className="mt-3">
                            <Badge variant="primary" className="p-2">
                                Package Price: <strong>{currentPackage.price}</strong>
                            </Badge>
                        </div>
                    </div>

                    <Row>
                        <Col lg={8}>
                            <Card className="shadow-sm border-0 mb-4">
                                <Card.Header className="bg-primary text-white">
                                    <h4 className="mb-0">Available Tests</h4>
                                </Card.Header>
                                <Card.Body className="p-0">
                                    <Table hover responsive className="mb-0">
                                        <thead className="bg-light">
                                            <tr>
                                                <th style={{ width: '50px' }}>Select</th>
                                                <th>Test Name</th>
                                                <th>Description</th>
                                                <th className="text-right">Price</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            {currentPackage.tests.map((test) => {
                                                const isSelected = selectedTests.some(t => t.id === test.id);
                                                return (
                                                    <tr key={test.id} className={isSelected ? "table-primary" : ""}>
                                                        <td className="text-center">
                                                            <input
                                                                type="checkbox"
                                                                checked={isSelected}
                                                                onChange={() => toggleTestSelection(test)}
                                                                className="form-check-input"
                                                                style={{ cursor: 'pointer' }}
                                                            />
                                                        </td>
                                                        <td>
                                                            <strong>{test.name}</strong>
                                                        </td>
                                                        <td>
                                                            <small className="text-muted">{test.description}</small>
                                                        </td>
                                                        <td className="text-right">
                                                            <strong className="text-primary">{test.price}</strong>
                                                        </td>
                                                    </tr>
                                                );
                                            })}
                                        </tbody>
                                    </Table>
                                </Card.Body>
                            </Card>
                        </Col>
                        <Col lg={4}>
                            <Card className="shadow-sm border-0 sticky-top" style={{ top: '20px' }}>
                                <Card.Header className="bg-success text-white">
                                    <h5 className="mb-0">Selected Tests</h5>
                                </Card.Header>
                                <Card.Body>
                                    {selectedTests.length === 0 ? (
                                        <p className="text-muted text-center mb-0">
                                            No tests selected. Select tests from the list.
                                        </p>
                                    ) : (
                                        <>
                                            <div className="mb-3">
                                                {selectedTests.map((test) => (
                                                    <div key={test.id} className="d-flex justify-content-between align-items-center mb-2 pb-2 border-bottom">
                                                        <div>
                                                            <small className="d-block font-weight-bold">{test.name}</small>
                                                            <small className="text-muted">{test.price}</small>
                                                        </div>
                                                        <Button
                                                            variant="link"
                                                            size="sm"
                                                            className="text-danger p-0"
                                                            onClick={() => toggleTestSelection(test)}
                                                        >
                                                            <i className="fa fa-times"></i>
                                                        </Button>
                                                    </div>
                                                ))}
                                            </div>
                                            <div className="border-top pt-3">
                                                <div className="d-flex justify-content-between mb-3">
                                                    <strong>Total:</strong>
                                                    <strong className="text-success h5 mb-0">
                                                        ₹{calculateTotal().toLocaleString()}
                                                    </strong>
                                                </div>
                                                <Button
                                                    variant="success"
                                                    className="btn-wide btn-pill btn-shadow btn-hover-shine w-100"
                                                    onClick={handleBookNow}
                                                >
                                                    Book Selected Tests
                                                </Button>
                                            </div>
                                        </>
                                    )}
                                </Card.Body>
                            </Card>
                        </Col>
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

export default IndividualTests;


