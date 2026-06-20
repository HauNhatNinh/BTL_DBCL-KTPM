import pytest
from calculator import Calculator

@pytest.fixture
def calc():
    return Calculator()

def test_add(calc):
    assert calc.add(2, 3) == 5
    assert calc.add(-1, 1) == 0

def test_divide(calc):
    assert calc.divide(10, 2) == 5
    with pytest.raises(ValueError, match="Cannot divide by zero"):
        calc.divide(10, 0)

@pytest.mark.parametrize("a, b, expected", [
    (1, 2, 3),
    (0, 0, 0),
    (-1, -1, -2),
    (100, 200, 300)
])
def test_add_parametrize(calc, a, b, expected):
    assert calc.add(a, b) == expected
