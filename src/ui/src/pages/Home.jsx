import { Col, Container, Row } from "react-bootstrap";
import { Link, Navigate } from "react-router-dom";
import { useAuth } from "../provider/authProvider";
import logo from "../assets/images/zorya_logo.png";
import heroImage from "../assets/images/originals/LMS.png";

const Home = () => {
    const { token } = useAuth();

    if (token && !token.logout) {
        return <Navigate to="/dashboard" replace />;
    }

    return (
        <div className="app-container app-theme-white body-tabs-shadow min-vh-100 d-flex flex-column bg-light">
            <header className="d-flex align-items-center justify-content-between py-4 px-5 border-bottom bg-white">
                <div className="d-flex align-items-center">
                    <img src={logo} alt="PathLab logo" height="56" className="mr-3" />
                    <div>
                        <p className="text-uppercase text-primary mb-1 font-weight-bold">PathLab Suite</p>
                        <p className="text-muted mb-0">Digital workflows for modern laboratories</p>
                    </div>
                </div>
                <Link
                    to="/login"
                    className="btn btn-primary btn-lg btn-shadow btn-hover-shine px-4"
                >
                    Login
                </Link>
            </header>

            <main className="flex-grow-1">
                <Container className="py-4">
                    <Row className="align-items-center gy-5">
                        <Col lg={6}>
                            <p className="text-uppercase text-primary font-weight-bold mb-2">Smarter lab operations</p>
                            <h1 className="display-5 font-weight-bold mb-4">
                                Manage diagnostics, reporting, and compliance in one place.
                            </h1>
                            <p className="lead text-muted mb-4">
                                Zorya Labroratory Management System streamlines patient onboarding, testing workflows, approvals,
                                and analytics so your teams can focus on delivering accurate and timely care.
                            </p>
                            <ul className="list-unstyled mb-4">
                                <li className="mb-2">
                                    <i className="fa fa-check text-success mr-2"></i>
                                    Centralized dashboards for administrators and clinicians
                                </li>
                                <li className="mb-2">
                                    <i className="fa fa-check text-success mr-2"></i>
                                    Role-based access with detailed audit logging
                                </li>
                                <li className="mb-2">
                                    <i className="fa fa-check text-success mr-2"></i>
                                    Automated alerts for approvals, escalations, and compliance
                                </li>
                            </ul>
                            <div className="d-flex flex-column flex-sm-row gap-3">
                                <Link to="/book-test" className="btn btn-primary btn-lg btn-shadow btn-hover-shine mb-3 mb-sm-0 mr-sm-3 px-4">
                                    Book a Test
                                </Link>
                                <Link to="/login" className="btn btn-outline-primary btn-lg btn-shadow btn-hover-shine mb-3 mb-sm-0 mr-sm-3 px-4">
                                    Start with Login
                                </Link>
                                <a href="mailto:hello@zorya.co.in" className="btn btn-outline-secondary btn-lg px-4">
                                    Talk to Sales
                                </a>
                            </div>
                        </Col>
                        <Col lg={6}>
                            <div className="card shadow-lg border-0">
                                 <div className="card-body p-0" style={{ height: "100%", width: "100%" }}>
                                    <img src={heroImage} alt="Laboratory dashboard" className="img-fluid rounded" />
                                </div>
                            </div>
                            {/* <div className="card border-0 shadow-sm mt-4">
                                <div className="card-body">
                                    <div className="d-flex justify-content-between text-center">
                                        <div>
                                            <p className="h3 mb-0 text-primary">250+</p>
                                            <small className="text-muted text-uppercase">Labs onboarded</small>
                                        </div>
                                        <div>
                                            <p className="h3 mb-0 text-primary">1.5M</p>
                                            <small className="text-muted text-uppercase">Reports issued</small>
                                        </div>
                                        <div>
                                            <p className="h3 mb-0 text-primary">99.9%</p>
                                            <small className="text-muted text-uppercase">Uptime</small>
                                        </div>
                                    </div>
                                </div>
                            </div> */}
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
}

export default Home;