"""
Tests for Config class
Copyright 2020 Microsoft
"""

from microsoft_bonsai_api.client import Config
from unittest.mock import patch


def test_default_config():
    config = Config()
    assert config.workspace == ""
    assert config.server == "https://api.bons.ai"


def test_config_reads_env_vars():
    with patch.dict(
        "os.environ",
        {
            "SIM_ACCESS_KEY": "111",
            "SIM_API_HOST": "https://bonsai-api.com",
            "SIM_WORKSPACE": "777",
            "SIM_CONTEXT": "TRAIN",
        },
    ):
        config = Config()
        assert config.access_key == "111"
        assert config.server == "https://bonsai-api.com"
        assert config.workspace == "777"


def test_config_reads_args():
    config = Config(
        argv=[
            __name__,
            "--accesskey",
            "111",
            "--api-host",
            "host",
            "--workspace",
            "test",
            "--sim-context",
            "context",
        ]
    )
    assert config.access_key == "111"
    assert config.server == "host"
    assert config.workspace == "test"
    assert config.simulator_context == "context"
