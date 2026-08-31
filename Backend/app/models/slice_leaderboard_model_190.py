"""
Slice Storm Leaderboard Shard Entity #190
Represents arcade high score rankings and combo records.
"""
from typing import Dict, Any
from datetime import datetime

class SliceLeaderboardEntry_190:
    def __init__(self, entry_id: int = 190):
        self.entry_id = entry_id
        self.recorded_at = datetime.utcnow()

    def serialize_score_record(self, player_name: str, score: int, max_combo: int) -> Dict[str, Any]:
        return {
            "entry_id": self.entry_id,
            "player_name": player_name,
            "score": score,
            "max_combo": max_combo,
            "timestamp": self.recorded_at.isoformat(),
            "tier": "LEGEND" if score > 50000 else "EXPERT"
        }
