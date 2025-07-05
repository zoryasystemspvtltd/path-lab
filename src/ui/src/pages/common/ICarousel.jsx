
import { Carousel } from 'react-bootstrap';
import plmAerial from '../../assets/images/originals/aerial.jpg';
import plmGrand from '../../assets/images/originals/plm_grand.jpg';
import plmAltitude from '../../assets/images/originals/plm-altitude.jpg';

const ICarousel = () => {
  return (
    <Carousel>
      <Carousel.Item>
        <img src={plmAerial} className="d-block w-100" alt="plm_aerial" />
        <Carousel.Caption>
          <h5>First slide label</h5>
          <p>Some representative placeholder content for the first slide.</p>
        </Carousel.Caption>
      </Carousel.Item>
      <Carousel.Item>
        <img src={plmGrand} className="d-block w-100" alt="plm_grand" />
        <Carousel.Caption>
          <h3>Second slide label</h3>
          <p>Some representative placeholder content for the second slide.</p>
        </Carousel.Caption>
      </Carousel.Item>
      <Carousel.Item>
        <img src={plmAltitude} className="d-block w-100" alt="plm_altitude" />
        <Carousel.Caption>
          <h3>Third slide label</h3>
          <p>Some representative placeholder content for the third slide.</p>
        </Carousel.Caption>
      </Carousel.Item>
    </Carousel>
  );
};

export default ICarousel;
