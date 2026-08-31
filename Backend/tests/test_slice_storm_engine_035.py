"""
Automated Pytest Matrix #035 for Slice Storm
Validates swipe velocity bounds, combo formulas, and AI gateway.
"""
import pytest
from Backend.app.repositories.slice_telemetry_repo_035 import SliceTelemetryRepository_035
from Backend.app.ai.nvidia_slicestorm_gateway_035 import NvidiaSliceStormGateway_035

def test_telemetry_validation_035():
    repo = SliceTelemetryRepository_035()
    assert repo.validate_slice_burst(cuts_count=20, duration_s=1.0) is True
    # Impossible cut speed (100 cuts in 0.5s = 200 cuts/s > 35)
    assert repo.validate_slice_burst(cuts_count=100, duration_s=0.5) is False

def test_score_calculation_035():
    repo = SliceTelemetryRepository_035()
    # (100 * 10) + (20 * 50) = 1000 + 1000 = 2000 * 2.0x = 4000
    score = repo.calculate_slice_score(regular_slices=100, combo_bonus_slices=20, multiplier=2.0)
    assert score == 4000

def test_nvidia_slicestorm_gateway_035():
    gw = NvidiaSliceStormGateway_035()
    debrief = gw.generate_player_debrief(total_slices=450, highest_combo=7, score=62000)
    assert debrief["rank"] == "BLADE_MASTER"
    assert "precision" in debrief["tactical_coach_tip"].lower()
